using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class SalaryServicesImpl : ISalaryServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public SalaryServicesImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<SalaryDto>> GetAllSalary()
        {
            var calculations =
                _mapper.Map<IEnumerable<Salary>, IEnumerable<SalaryDto>>(
                    await _repository.Salary.GetAllSalary(trackChanges: false));
            return _mapper.Map<IEnumerable<SalaryDto>>(calculations);
        }

        public async Task<SalaryDto> GetSalaryById(Guid salaryId)
        {
            var calculation = await _repository.Salary.GetSalaryById(salaryId);

            return _mapper.Map<SalaryDto>(calculation);
        }
        public async Task CreateSalary(SalaryRequest calculation)
        {
            var calculationEntity = new Salary()
            {
                Date = calculation.Date.Date,
                Advance = calculation.Advance,
                NumberOfHours = calculation.NumberOfHours,
                Rate = calculation.Rate,
            };
            _repository.Salary.CreateSalary(calculationEntity);
            await _repository.SaveAsync();
        }
        public async Task UpdateSalary(Guid salaryId, SalaryRequest calculation)
        {
            var calculationEntity = await _repository.Salary.GetSalaryById(salaryId);

            calculationEntity.Advance = calculation.Advance;
            calculationEntity.NumberOfHours = calculationEntity.NumberOfHours;
            calculationEntity.Rate = calculationEntity.Rate;
            _repository.Salary.UpdateSalary(calculationEntity);
            await _repository.SaveAsync();
        }
        public async Task DeleteSalary(Guid salaryId)
        {
            var calculationEntity = await _repository.Salary.GetSalaryById(salaryId);
            _repository.Salary.DeleteSalary(calculationEntity);
            await _repository.SaveAsync();
        }

    }
}