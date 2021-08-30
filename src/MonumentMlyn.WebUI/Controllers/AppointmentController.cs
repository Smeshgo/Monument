using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO.Appointment;
using MonumentMlyn.BLL.Services;
using System;
using System.Threading.Tasks;

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
        // GET: /Appointment
        [HttpGet]
        public async Task<IActionResult> GetALLAppointment()
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
        // GET: /Appointment/id
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

        // POST: /Appointment/create
        [HttpPost]
        public async Task<IActionResult> CreateAppointment([FromBody] AppointmentRequest appointment)
        {
            try
            {
                if (appointment == null)
                {
                    return BadRequest("appointment object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _appointment.CreateAppointment(appointment);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        // PUT: /Appointment/id
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAppointment(Guid id, [FromBody] AppointmentRequest appointment)
        {
            try
            {
                if (appointment == null)
                {
                    return BadRequest("appointment object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                var appointmentEntity = await _appointment.GetAppointmentById(id);
                if (appointmentEntity == null)
                {
                    return NotFound();
                }

                await _appointment.UpdateAppointment(id, appointment);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        // DELETE: /Appointment/id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppoinment(Guid id)
        {
            try
            {
                var appoinmentEntity = await _appointment.GetAppointmentById(id);
                if (appoinmentEntity == null)
                {

                    return NotFound();
                }

                await _appointment.DeleteAppointment(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}