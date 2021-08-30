using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.DTO.Appointment;

namespace MonumentMlyn.BLL.Services
{
    public interface IAppointmentServices
    {
        Task<IEnumerable<AppointmentDto>> GetAllAppointments();
        Task<AppointmentDto> GetAppointmentById(Guid idAppointment);
        Task CreateAppointment(AppointmentRequest appointment);
        Task UpdateAppointment(Guid idAppointment, AppointmentRequest appointment);
        Task DeleteAppointment(Guid idAppointment);
    }
}
