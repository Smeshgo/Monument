using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.DTO.Appointment;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class AppointmentServiceImpl : IAppointmentServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public AppointmentServiceImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AppointmentDto>> GetAllAppointments()
        {
            var appointment =
                _mapper.Map<IEnumerable<Appointment>, IEnumerable<AppointmentDto>>(
                    await _repository.Appointment.GetAllAppointments(trackChanges: false));

            return _mapper.Map<IEnumerable<AppointmentDto>>(appointment);
        }

        public async Task<AppointmentDto> GetAppointmentById(Guid idAppointment)
        {
            var appointment = await _repository.Appointment.GetAppointmentById(idAppointment);

            return _mapper.Map<AppointmentDto>(appointment);
        }

        public async Task CreateAppointment(AppointmentRequest appointment)
        {

            var appointmentEntity = new Appointment
            {
                IdAppointment = Guid.NewGuid(),
                Name = appointment.Name,
                CreateAppointment = DateTime.Now,
                Update = DateTime.Now
            };

            _repository.Appointment.CreateAppointment(appointmentEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateAppointment(Guid idAppointment, AppointmentRequest appointment)
        {
            var appointmentEntity = await _repository.Appointment.GetAppointmentById(idAppointment);


            appointmentEntity.Name = appointment.Name;
            appointmentEntity.Update = DateTime.Now;

            _repository.Appointment.UpdateAppointment(appointmentEntity);
            await _repository.SaveAsync();

        }

        public async Task DeleteAppointment(Guid idAppointment)
        {
            var appointmentEntity = await _repository.Appointment.GetAppointmentById(idAppointment);

            _repository.Appointment.DeleteAppointment(appointmentEntity);
            await _repository.SaveAsync();
        }
    }
}
