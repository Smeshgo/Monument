using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

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

        public async Task<PhotoDto> GetPhotoById(Guid idPhoto)
        {
            var photo = await _repository.Photo.GetPhotoById(idPhoto);

            return _mapper.Map<PhotoDto>(photo);
        }

        public async Task<byte[]> ImageToBase64(string path)
        {
           using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                await using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    return imageBytes;
                }
            }
        }
        public async Task CreatePhoto(PhotoRequest photo)
        {
            var photoEntity = new Photo()
            {
                IdPhoto = Guid.NewGuid(),
                Name = photo.Name,
                CreatePhoto = DateTime.Now,
                UpdatePhoto = DateTime.Now,
                CategoryPhoto = photo.CategoryPhoto,
                FullPhoto = ImageToBase64(photo.PathFull).Result,
                MinyPhoto = ImageToBase64(photo.PathMini).Result

            };

            _repository.Photo.CreatePhoto(photoEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdatePhoto(Guid idPhoto, PhotoRequest photo)
        {
            var photoEntity = new Photo()
            {
                Name = photo.Name,
                UpdatePhoto = DateTime.Now,
                CategoryPhoto = photo.CategoryPhoto,
                FullPhoto = ImageToBase64(photo.PathFull).Result,
                MinyPhoto = ImageToBase64(photo.PathMini).Result
            };

            
            _repository.Photo.UpdatePhoto(photoEntity);
            await _repository.SaveAsync();
        }

        public async Task DeletePhoto(Guid idPhoto)
        {
            var photoEntity = await _repository.Photo.GetPhotoById(idPhoto);

            _repository.Photo.DeletePhoto(photoEntity);
            await _repository.SaveAsync();
        }
    }
}