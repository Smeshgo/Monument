using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MonumentMlyn.DAL.Repositorie
{
    public class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }
        /// <summary>
        /// Method for get all attachments from db.
        /// </summary>
        /// <param name="trackChanges">parameter that help in tracking changes.</param>
        /// <returns>list of all Appointment.</returns>
        public async Task<IEnumerable<Appointment>> GetAllAppointments(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToListAsync();

        /// <summary>
        /// Method for get attachment by id from db.
        /// </summary>
        /// <param name="idAppointment">id of attachment.</param>
        /// <returns>get Appointment.</returns>
        public async Task<Appointment> GetAppointmentById(int idAppointment)
        {
            return await FindByCondition(x => x.IdAppointment.Equals(idAppointment))
                .FirstOrDefaultAsync();
        }
        /// <summary>
        /// Method for get attachment with details from db.
        /// </summary>
        /// <param name="idAppointment">id of attachment.</param>
        /// <returns>get Appointment with details.</returns>
        public Appointment GetAppointmentWithDetails(int idAppointment)
        {
            return FindByCondition(owner => owner.IdAppointment.Equals(idAppointment)).FirstOrDefault();
        }

        // <summary>
        /// Method for create attachment in db.
        /// </summary>
        /// <param name="appointment">new attachment.</param>
        public void CreateAppointment(Appointment appointment)
        {
            Create(appointment);
        }

        /// <summary>
        /// Method for update attachment in db.
        /// </summary>
        /// <param name="appointment">updated attachment.</param>
        public void UpdateAppointment(Appointment appointment)
        {
            Update(appointment);
        }

        /// <summary>
        /// Method for deleting attachment from db.
        /// </summary>
        /// <param name="appointment">deleted attachment.</param>
        public void DeleteAppointment(Appointment appointment)
        {
            Delete(appointment);
        }
      
    }
}