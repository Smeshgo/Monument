using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class PhotoServicesImpl : IPhotoServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public PhotoServicesImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PhotoDto>> GetAllPhotos()
        {
            var photos =
                _mapper.Map<IEnumerable<Photo>, IEnumerable<PhotoDto>>(
                    await _repository.Photo.GetAllPhoto(trackChanges: false));

            return _mapper.Map<IEnumerable<PhotoDto>>(photos);
        }

        public async Task<PhotoDto> GetPhotoById(int idPhoto)
        {
            var photo = await _repository.Photo.GetPhotoById(idPhoto);

            return _mapper.Map<PhotoDto>(photo);
        }

        public async Task CreatePhoto(PhotoDto photo)
        {
            var photoEntity = _mapper.Map<Photo>(photo);
            _repository.Photo.CreatePhoto(photoEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdatePhoto(int idPhoto, PhotoDto photo)
        {
            var photoEntity = await _repository.Photo.GetPhotoById(idPhoto);

            _mapper.Map(photo, photoEntity);
            _repository.Photo.UpdatePhoto(photoEntity);
            await _repository.SaveAsync();
        }

        public async Task DeletePhoto(int idPhoto)
        {
            var photoEntity = await _repository.Photo.GetPhotoById(idPhoto);

            _repository.Photo.DeletePhoto(photoEntity);
            await _repository.SaveAsync();
        }
    }
}