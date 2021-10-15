using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MonumentMlyn.DAL.Entities;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class WorkerDto
    {
        public WorkerDto()
        {
            
        }

        public WorkerDto(Guid workerId, string firstName, string phone, string lastName, DateTime? createWorker, DateTime? updateWorker)
        {
            WorkerId = workerId;
            FirstName = firstName;
            Phone = phone;
            LastName = lastName;
            CreateWorker = createWorker;
            UpdateWorker = updateWorker;
        }
        public Guid WorkerId { get; set; }
        public string FirstName { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"((\+38)?\(?\d{3}\)?[\s\.-]?(\d{7}|\d{3}[\s\.-]\d{2}[\s\.-]\d{2}|\d{3}-\d{4}))",
            ErrorMessage = "Not a valid phone number")]
        [Required]
        public string Phone { get; set; }
        public string LastName { get; set; }
        public DateTime? CreateWorker { get; set; }
        public DateTime? UpdateWorker { get; set; }
        public virtual ICollection<Salary> Salary { get; set; } = new List<Salary>();
    }
}
