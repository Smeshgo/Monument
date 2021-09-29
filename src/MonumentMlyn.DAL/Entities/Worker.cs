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

        public Worker(Guid workerId, string firstName, string phone, string lastName, DateTime? createWorcer, DateTime? updateWorker, ICollection<Calculations> calculations, ICollection<Monument> monumentWorkers)
        {
            WorkerId = workerId;
            FirstName = firstName;
            Phone = phone;
            LastName = lastName;
            CreateWorcer = createWorcer;
            UpdateWorker = updateWorker;
            Calculations = calculations;
            MonumentWorkers = monumentWorkers;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WorkerId { get; set; }
        public string FirstName { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"((\+38)?\(?\d{3}\)?[\s\.-]?(\d{7}|\d{3}[\s\.-]\d{2}[\s\.-]\d{2}|\d{3}-\d{4}))",
            ErrorMessage = "Not a valid phone number")]
        [Required]
        public string Phone { get; set; }
        public string LastName { get; set; }
        public DateTime? CreateWorcer { get; set; }
        public DateTime? UpdateWorker { get; set; }

        public virtual ICollection<Calculations> Calculations { get; set; } = new List<Calculations>();
        public virtual ICollection<Monument> MonumentWorkers { get; set; } = new List<Monument>();

        //public List<Calculations> Calculations { get; set; } = new List<Calculations>();
        //public List<Monument> Monuments { get; set; } = new List<Monument>();
    }
}
