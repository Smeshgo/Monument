using System;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class AppointmentDto
    {
        public AppointmentDto()
        {

        }

        public AppointmentDto(Guid idAppointment, string name, DateTime createAppointment, DateTime update)
        {
            this.IdAppointment = idAppointment;
            this.Name = name;
            this.CreateAppointment = createAppointment;
            this.Update = update;
        }

        public Guid IdAppointment { get; set; }
        public string Name { get; set; }
        public DateTime? CreateAppointment { get; set; }
        public DateTime? Update { get; set; }

        
    }
}
