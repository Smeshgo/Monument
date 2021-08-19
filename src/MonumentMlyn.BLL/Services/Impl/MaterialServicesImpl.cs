using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class MaterialServicesImpl : IMaterialServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public MaterialServicesImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<MaterialDto>> GetAllMaterials()
        {
            var materials =
                _mapper.Map<IEnumerable<Material>, IEnumerable<MaterialDto>>(
                    await _repository.Material.GetAllMaterial(trackChanges: false));

            return _mapper.Map<IEnumerable<MaterialDto>>(materials);
        }

        public async Task<MaterialDto> GetMaterialById(int idMaterial)
        {
            var material = await _repository.Material.GetMaterialtById(idMaterial);

            return _mapper.Map<MaterialDto>(material);
        }

        public async Task CreateMaterial(MaterialDto material)
        {
            var materialEntity = _mapper.Map<Material>(material);

            _repository.Material.CreateMaterial(materialEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateMaterial(int idMaterial, MaterialDto material)
        {
            var materialEntity = await _repository.Material.GetMaterialtById(idMaterial);

            _mapper.Map(material, materialEntity);
            _repository.Material.UpdateMaterial(materialEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteMaterial(int idMaterial)
        {
            var materialEntity = await _repository.Material.GetMaterialtById(idMaterial);

            _repository.Material.DeleteMaterial(materialEntity);
            await _repository.SaveAsync();
        }
    }
}