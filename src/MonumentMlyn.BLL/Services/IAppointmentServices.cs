using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface IAppointmentServices
    {
        Task<IEnumerable<AppointmentDto>> GetAllAppointments();
        Task<AppointmentDto> GetAppointmentById(Guid idAppointment);
        Task CreateAppointment(AppointmentDto appointment);
        Task UpdateAppointment(Guid idAppointment, AppointmentDto appointment);
        Task DeleteAppointment(Guid idAppointment);
    }
}