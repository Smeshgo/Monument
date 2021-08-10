using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Appointment
    {
        public Appointment()
        {
            Materials = new HashSet<Material>();
        }
        [Key]
        public Guid IdAppointment { get; set; }
        public string Name { get; set; }
        public DateTime? CreateAppointment { get; set; }
        public DateTime? Update { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
    }
}
