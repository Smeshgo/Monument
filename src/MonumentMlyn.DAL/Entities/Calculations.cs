using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonumentMlyn.DAL.Entities
{
    public class Calculations
    {
        public Calculations()
        {
            
        }

        public Calculations(Guid idWorker, DateTime date, decimal advance, decimal numberOfHours, decimal rete, decimal salary)
        {
            IdWorker = idWorker;
            Date = date;
            Advance = advance;
            NumberOfHours = numberOfHours;
            Rete = rete;
            Salary = salary;
        }
        public Guid IdWorker { get; set; }

        public DateTime Date { get; set; }
        public Decimal Advance { get; set; }
        public decimal NumberOfHours { get; set; }
        public decimal Rete { get; set; }
        public decimal Salary { get; set; }
        public Worker Worker { get; set; } = new Worker();
    }
}