using System;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO.CategoryMaterial;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class CategoryMaterialServicesImpl : ICategoryMaterialServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public CategoryMaterialServicesImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryMaterialDto>> GetAllCategoryMaterial()
        {
            var categoryMaterials =
                _mapper.Map<IEnumerable<CategoryMaterial>, IEnumerable<CategoryMaterialDto>>(
                    await _repository.CategoryMaterial.GetAllCategoryMaterial(trackChanges: false));
            return _mapper.Map<IEnumerable<CategoryMaterialDto>>(categoryMaterials);

        }

        public async Task<CategoryMaterialDto> GetCategoryMaterialById(Guid id)
        {
            var categoryMateria = await _repository.CategoryMaterial.GetCategoryMaterialById(id);
            return _mapper.Map<CategoryMaterialDto>(categoryMateria);
        }

        public async Task CreateCategoryMaterial(CategoryMaterialRequest categoryMaterial)
        {
            var categoryMateriaEntity = new CategoryMaterial()
            {
                IdCategoryMaterial = Guid.NewGuid(),
                Name = categoryMaterial.Name,
                CreateCategoryMaterial = DateTime.Now,
                UpdateCategoryMaterial = DateTime.Now
            };

            _repository.CategoryMaterial.CreateCategoryMaterial(categoryMateriaEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateCategoryMaterial(Guid id, CategoryMaterialRequest categoryMaterial)
        {
            var categoryMateriaEntity = await _repository.CategoryMaterial.GetCategoryMaterialById(id);

            categoryMateriaEntity.Name = categoryMaterial.Name;
            categoryMateriaEntity.UpdateCategoryMaterial = DateTime.Now;

            _repository.CategoryMaterial.UpdateCategoryMaterial(categoryMateriaEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteCategoryMaterial(Guid id)
        {
            var categoryMateriaEntity = await _repository.CategoryMaterial.GetCategoryMaterialById(id);

            _repository.CategoryMaterial.DeleteCategoryMaterial(categoryMateriaEntity);
            await _repository.SaveAsync();
        }
    }
}