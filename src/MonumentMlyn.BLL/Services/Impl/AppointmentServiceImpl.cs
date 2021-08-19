using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;

namespace MonumentMlyn.BLL.Services.Impl
{
    class AppointmentServiceImpl : IAppointmentServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public AppointmentServiceImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AppointmentDto>> GetAllAppointments(bool trackChanges)
        {
            var companies =
                _mapper.Map<IEnumerable<Appointment>, IEnumerable<AppointmentDto>>(
                    await _repository.Appointment.GetAllAppointments(trackChanges: false));

            return _mapper.Map<IEnumerable<AppointmentDto>>(companies);
        }

        public async Task<AppointmentDto> GetAppointmentById(int idAppointment)
        {
            var appointment = await _repository.Appointment.GetAppointmentById(idAppointment);

            return _mapper.Map<AppointmentDto>(appointment);
        }

        public async Task CreateAppointment(AppointmentDto appointment)
        {
            var appointmentEntity = _mapper.Map<Appointment>(appointment);
            _repository.Appointment.CreateAppointment(appointmentEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateAppointment(int idAppointment, AppointmentDto appointment)
        {
            var appointmentEntity = await _repository.Appointment.GetAppointmentById(idAppointment);

            _mapper.Map(appointment, appointmentEntity);
            _repository.Appointment.UpdateAppointment(appointmentEntity);
            await _repository.SaveAsync();

        }

        public async Task DeleteAppointment(int idAppointment)
        {
            var appointmentEntity = await _repository.Appointment.GetAppointmentById(idAppointment);
            _repository.Appointment.DeleteAppointment(appointmentEntity);
            await _repository.SaveAsync();
        }
    }
}
