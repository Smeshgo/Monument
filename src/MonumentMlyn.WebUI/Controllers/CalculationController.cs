using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/Calculation")]
    [ApiController]
    public class CalculationController : Controller
    {
        private readonly ISalaryServices _calculationsServices;

        public CalculationController(ISalaryServices calculationsServices)
        {
            _calculationsServices = calculationsServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCalculation()
        {
            try
            {
                var calculationDto = await _calculationsServices.GetAllSalary();
                return Ok(calculationDto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error " + e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCalculationById(Guid id)
        {
            try
            {
                var calculationResult = await _calculationsServices.GetSalaryById(id);
                return Ok(calculationResult);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCalculation([FromBody] SalaryRequest calculations)
        {
            try
            {
                if (calculations == null)
                {
                    return BadRequest("Article object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _calculationsServices.CreateSalary(calculations);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCalculation(Guid id, [FromBody] SalaryRequest calculations)
        {
            try
            {
                if (calculations == null)
                {
                    return BadRequest("article object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }


                var calculationEntity = await _calculationsServices.GetSalaryById(id);

                if (calculationEntity == null)
                {
                    return NotFound();
                }

                await _calculationsServices.UpdateSalary(id, calculations);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCalculation(Guid id)
        {
            try
            {

                var calculationEntity = await _calculationsServices.GetSalaryById(id);

                if (calculationEntity == null)
                {
                    return NotFound();
                }
                await _calculationsServices.DeleteSalary(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}
