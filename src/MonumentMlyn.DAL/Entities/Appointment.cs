using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.SqlServer.Server;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public class Appointment
    {
        public Appointment()
        {
            
        }

        public Appointment(Guid idAppointment, string name, DateTime? createAppointment, DateTime? update)
        {
            IdAppointment = idAppointment;
            Name = name;
            CreateAppointment = createAppointment;
            Update = update;
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdAppointment { get; set; }
        public string Name { get; set; }
        public DateTime? CreateAppointment { get; set; }
        public DateTime? Update { get; set; }
       
        
    }
}
