using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface IAppointmentServices
    {
        Task<IEnumerable<AppointmentDto>> GetAllAppointments(bool trackChanges);
        Task<AppointmentDto> GetAppointmentById(int idAppointment);
        Task CreateAppointment(AppointmentDto appointment);
        Task UpdateAppointment(int idAppointment, AppointmentDto appointment);
        Task DeleteAppointment(int idAppointment);
    }
}