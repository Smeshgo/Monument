using System;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<CategoryMaterialDto> GetCategoryMaterialById(Guid idcategoryMaterial)
        { 
            var categoryMateria = await _repository.CategoryMaterial.GetCategoryMaterialById(idcategoryMaterial);
            return _mapper.Map<CategoryMaterialDto>(categoryMateria);
        }

        public async Task CreateCategoryMaterial(CategoryMaterialDto categoryMaterial)
        {
            var categoryMateriaEntity = _mapper.Map<CategoryMaterial>(categoryMaterial);

            _repository.CategoryMaterial.CreateCategoryMaterial(categoryMateriaEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateCategoryMaterial(Guid idcategoryMaterial, CategoryMaterialDto categoryMaterial)
        {
            var categoryMateriaEntity = await _repository.CategoryMaterial.GetCategoryMaterialById(idcategoryMaterial);

            _mapper.Map(categoryMaterial, categoryMateriaEntity);
            _repository.CategoryMaterial.UpdateCategoryMaterial(categoryMateriaEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteCategoryMaterial(Guid idcategoryMaterial)
        {
            var categoryMateriaEntity = await _repository.CategoryMaterial.GetCategoryMaterialById(idcategoryMaterial);

            _repository.CategoryMaterial.DeleteCategoryMaterial(categoryMateriaEntity);
            await _repository.SaveAsync();
        }
    }
}