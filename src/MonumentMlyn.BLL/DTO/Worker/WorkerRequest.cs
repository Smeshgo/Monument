using System;
using System.ComponentModel.DataAnnotations;

namespace MonumentMlyn.BLL.DTO
{
    public class WorkerRequest
    {
        public WorkerRequest()
        {
            
        }

        public WorkerRequest(string firstName, string phone, string lastName)
        {
            FirstName = firstName;
            Phone = phone;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"((\+38)?\(?\d{3}\)?[\s\.-]?(\d{7}|\d{3}[\s\.-]\d{2}[\s\.-]\d{2}|\d{3}-\d{4}))",
            ErrorMessage = "Not a valid phone number")]
        [Required]
        public string Phone { get; set; }
        public string LastName { get; set; }
    }
}