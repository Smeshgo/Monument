using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MonumentMlyn.DAL.Entities
{
    public class Salary
    {
        public Salary()
        {

        }

        public Salary(Guid workerId, DateTime date, decimal advance, decimal numberOfHours, decimal rate)
        {
            WorkerId = workerId;
            Date = date;
            Advance = advance;
            NumberOfHours = numberOfHours;
            Rate = rate;
        }
        public Guid WorkerId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        public decimal Advance { get; set; }
        public decimal NumberOfHours { get; set; }
        public decimal Rate { get; set; }
        public decimal Premium { get; set; }
        public decimal Penalty { get; set; }
        public string Description { get; set; }
        public decimal DaySalary { get; set; }

        [JsonIgnore]
        public virtual Worker Worker { get; set; } = new Worker();
    }
}