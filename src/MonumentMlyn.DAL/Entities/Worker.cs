using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public class Worker
    {
        public Worker()
        {
        }

        public Worker(Guid workerId, string firstName, string phone, string lastName, DateTime? createWorker, DateTime? updateWorker)
        {
            WorkerId = workerId;
            FirstName = firstName;
            Phone = phone;
            LastName = lastName;
            CreateWorker = createWorker;
            UpdateWorker = updateWorker;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WorkerId { get; set; }
        public string FirstName { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"((\+38)?\(?\d{3}\)?[\s\.-]?(\d{7}|\d{3}[\s\.-]\d{2}[\s\.-]\d{2}|\d{3}-\d{4}))",
            ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
        public string Specialty { get; set; }

        public DateTime? CreateWorker { get; set; }
        public DateTime? UpdateWorker { get; set; }
        public DateTime? DeleteDate { get; set; }



        //[ForeignKey("SalaryId")]
        public virtual ICollection<Salary> Salary { get; set; } = new List<Salary>();

        [JsonIgnore]
        public virtual ICollection<Monument> MonumentWorkers { get; set; } = new List<Monument>();

    }
}
