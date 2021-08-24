using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/Appointment")]

    [ApiController]
    public class AppointmentController : ControllerBase
    {
        // GET
        private readonly IAppointmentServices _appointment;

        public AppointmentController(IAppointmentServices appointment)
        {
            _appointment = appointment;
        }

        [HttpGet]
        public async Task<IActionResult> GetAppointment()
        {
            try
            {
                var appointmentDto = await _appointment.GetAllAppointments();
                return Ok(appointmentDto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Appointment server error" + e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetappointmentById(Guid id)
        {
            try
            {
                var appointmentResult = await _appointment.GetAppointmentById(id);
                return Ok(appointmentResult);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
            
        }

        // POST: /issues/create
    }
}