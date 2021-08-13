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
        }
        public Appointment(Guid idAppointment, string name, DateTime? createAppointment, DateTime? update, Guid idMaterial)
        {
            IdAppointment = idAppointment;
            Name = name;
            CreateAppointment = createAppointment;
            Update = update;
        }
        [Key]
        public Guid IdAppointment { get; set; }
        public string Name { get; set; }
        public DateTime? CreateAppointment { get; set; }
        public DateTime? Update { get; set; }
        public List<Material> Materials { get; set; } = new List<Material>();
        
    }
}
