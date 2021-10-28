using System;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.DTO
{
    public class SalaryRequest
    {
        public SalaryRequest(DateTime date, decimal advance, decimal numberOfHours, decimal rate, DateTime dateOld)
        {
            Date = date;
            Advance = advance;
            NumberOfHours = numberOfHours;
            Rate = rate;
            DateOld = dateOld;
        }
        public DateTime Date { get; set; }
        public decimal Advance { get; set; }
        public decimal NumberOfHours { get; set; }
        public decimal Rate { get; set; }
        public DateTime DateOld { get; set; }
    }
}