using System;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.DTO
{
    public class SalaryDto
    {
        public SalaryDto(Guid workerId, DateTime date, decimal advance, decimal numberOfHours, decimal rate, decimal salary)
        {
            WorkerId = workerId;
            Date = date;
            Advance = advance;
            NumberOfHours = numberOfHours;
            Rate = rate;
            Salary = salary;
        }
        public Guid WorkerId { get; set; }

        public DateTime Date { get; set; }
        public decimal Advance { get; set; }
        public decimal NumberOfHours { get; set; }
        public decimal Rate { get; set; }
        public decimal Salary { get; set; }

    }
}