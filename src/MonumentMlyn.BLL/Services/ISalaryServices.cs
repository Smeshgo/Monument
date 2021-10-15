using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.DTO.Article;

namespace MonumentMlyn.BLL.Services
{
    public interface ISalaryServices
    {
        Task<IEnumerable<SalaryDto>> GetAllSalary();
        Task<SalaryDto> GetSalaryById(Guid SalaryId);
        Task CreateSalary(SalaryRequest salary);
        Task UpdateSalary(Guid SalaryId, SalaryRequest salary);
        Task DeleteSalary(Guid SalaryId);
    }
}