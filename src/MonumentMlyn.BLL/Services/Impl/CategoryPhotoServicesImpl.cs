using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class CategoryPhotoServicesImpl : ICategoryPhotoServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public CategoryPhotoServicesImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryPhotoDto>> GetAllCategoryPhoto()
        {
            var categoryPhotos =
                _mapper.Map<IEnumerable<CategoryPhoto>, IEnumerable<CategoryPhotoDto>>(
                    await _repository.CategoryPhoto.GetAllCategoryPhotos(trackChanges: false));

            return _mapper.Map<IEnumerable<CategoryPhotoDto>>(categoryPhotos);
        }

        public async Task<CategoryPhotoDto> GetCategoryPhotoById(int idCategoryPhoto)
        {
            var categoryPhoto = await _repository.CategoryPhoto.GetCategoryPhotoById(idCategoryPhoto);

            return _mapper.Map<CategoryPhotoDto>(categoryPhoto);
        }

        public async Task CreateCategoryPhoto(CategoryPhotoDto categoryPhoto)
        {
            var categoryPhotoEntity = _mapper.Map<CategoryPhoto>(categoryPhoto);

            _repository.CategoryPhoto.CreateCategoryPhoto(categoryPhotoEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateCategoryPhoto(int idCategoryPhoto, CategoryPhotoDto categoryPhoto)
        {
            var categoryPhotoEntity = await _repository.CategoryPhoto.GetCategoryPhotoById(idCategoryPhoto);

            _mapper.Map(categoryPhoto, categoryPhotoEntity);
            _repository.CategoryPhoto.UpdateCategoryPhoto(categoryPhotoEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteCategoryPhoto(int idCategoryPhoto)
        {
            var categoryPhotoEntity = await _repository.CategoryPhoto.GetCategoryPhotoById(idCategoryPhoto);

            _repository.CategoryPhoto.DeleteCategoryPhoto(categoryPhotoEntity);
            await _repository.SaveAsync();
        }
    }
}