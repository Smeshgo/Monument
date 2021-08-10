using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class WorkerDTO
    {
        public WorkerDTO()
        {
            MonumentWorkers = new HashSet<MonumentWorkerDTO>();
        }

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

        public virtual ICollection<MonumentWorkerDTO> MonumentWorkers { get; set; }
    }
}
