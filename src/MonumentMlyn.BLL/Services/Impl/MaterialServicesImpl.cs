using System;
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
                    await _repository.Material.GetAllMaterial());

            return _mapper.Map<IEnumerable<MaterialDto>>(materials);
        }

        public async Task<MaterialDto> GetMaterialById(Guid idMaterial)
        {
            var material = await _repository.Material.GetMaterialtById(idMaterial);

            return _mapper.Map<MaterialDto>(material);
        }

        public async Task CreateMaterial(MaterialRequest material)
        {
            var materialEntity = new Material()
            {
                MaterialId = new Guid(),
                Name = material.Name,
                Height = material.Height,
                Length = material.Length,
                Color = material.Color,
                Width = material.Width,
                Price = material.Price,
                Number = material.Number,
                Status = material.Status,
                Appointment = material.Appointment,
                Category = material.Category,
                CreateMaterial = DateTime.Now,
                UpdateMaterial = DateTime.Now
            };

            _repository.Material.CreateMaterial(materialEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateMaterial(Guid idMaterial, MaterialRequest material)
        {
            var materialEntity = await _repository.Material.GetMaterialtById(idMaterial);

            materialEntity.Name = material.Name;
            materialEntity.Height = material.Height;
            materialEntity.Length = material.Length;
            materialEntity.Color = material.Color;
            materialEntity.Width = material.Width;
            materialEntity.Price = material.Price;
            materialEntity.Number = material.Number;
            materialEntity.Status = material.Status;
            materialEntity.Appointment = material.Appointment;
            materialEntity.Category = material.Category;
            materialEntity.UpdateMaterial = DateTime.Now;


            _repository.Material.UpdateMaterial(materialEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteMaterial(Guid idMaterial)
        {
            var materialEntity = await _repository.Material.GetMaterialtById(idMaterial);

            _repository.Material.DeleteMaterial(materialEntity);
            await _repository.SaveAsync();
        }
    }
}