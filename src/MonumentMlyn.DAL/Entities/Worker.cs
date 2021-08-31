using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Worker
    {
        public Worker()
        {
            
        }

        public Worker(Guid idWorker, string firstName, decimal numberOfHours, decimal rete, string phone, decimal salary, string lastName, DateTime? createWorcer, DateTime? updateWorker)
        {
            IdWorker = idWorker;
            FirstName = firstName;
            NumberOfHours = numberOfHours;
            Rete = rete;
            Phone = phone;
            Salary = salary;
            LastName = lastName;
            CreateWorcer = createWorcer;
            UpdateWorker = updateWorker;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdWorker { get; set; }
        public string FirstName { get; set; }
        public decimal NumberOfHours { get; set; }
        public decimal Rete { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"((\+38)?\(?\d{3}\)?[\s\.-]?(\d{7}|\d{3}[\s\.-]\d{2}[\s\.-]\d{2}|\d{3}-\d{4}))",
            ErrorMessage = "Not a valid phone number")]
        [Required]
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public string LastName { get; set; }
        public DateTime? CreateWorcer { get; set; }
        public DateTime? UpdateWorker { get; set; }

        public List<Monument> Monuments { get; set; } = new List<Monument>();
    }
}
