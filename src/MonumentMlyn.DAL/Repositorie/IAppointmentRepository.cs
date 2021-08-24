using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public interface IAppointmentRepository : IRepositoryBase<Appointment>
    {
        Task<IEnumerable<Appointment>> GetAllAppointments(bool trackChanges);
        Task<Appointment> GetAppointmentById(Guid idAppointment);
        Appointment GetAppointmentWithDetails(Guid idAppointment);
        void CreateAppointment(Appointment appointment);
        void UpdateAppointment(Appointment appointment);
        void DeleteAppointment(Appointment appointment);
    }
}
