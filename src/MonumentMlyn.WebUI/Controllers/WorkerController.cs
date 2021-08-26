using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;
using System;
using System.Threading.Tasks;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/Worker")]

    [ApiController]
    public class WorkerController : Controller
    {
        private readonly IWorkerServices _workerServices;

        public WorkerController(IWorkerServices workerServices)
        {
            _workerServices = workerServices;
        }

        // GET /Worker
        [HttpGet]
        public async Task<IActionResult> GetAllWorker()
        {
            try
            {
                var workerDto = await _workerServices.GetAllWorkers();
                return Ok(workerDto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorkerById(Guid id)
        {
            try
            {
                var workerResult = await _workerServices.GetWorkerById(id);
                return Ok(workerResult);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateWorker([FromBody] WorkerDto worker)
        {
            try
            {
                if (worker == null)
                {
                    return BadRequest("Worker object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _workerServices.CreateWorker(worker);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWorker(Guid id, [FromBody] WorkerDto worker)
        {
            try
            {
                if (worker == null)
                {
                    return BadRequest("Worker object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }


                var workerEntity = await _workerServices.GetWorkerById(id);

                if (workerEntity == null)
                {
                    return NotFound();
                }

                await _workerServices.UpdateWorker(id, worker);
                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorker(Guid id)
        {
            try
            {

                var workerEntity = await _workerServices.GetWorkerById(id);

                if (workerEntity == null)
                {
                    return NotFound();
                }

                await _workerServices.DeleteWorker(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}