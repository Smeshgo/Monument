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

        public Calculations(Guid workerId, DateTime date, decimal advance, decimal numberOfHours, decimal rete, decimal salary)
        {
            WorkerId = workerId;
            Date = date;
            Advance = advance;
            NumberOfHours = numberOfHours;
            Rete = rete;
            Salary = salary;
        }
        public Guid WorkerId { get; set; }

        public DateTime Date { get; set; }
        public Decimal Advance { get; set; }
        public decimal NumberOfHours { get; set; }
        public decimal Rete { get; set; }
        public decimal Salary { get; set; }
        public virtual Worker Worker { get; set; } = new Worker();
    }
}