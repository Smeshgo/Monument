using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO.Monument;
using MonumentMlyn.BLL.Services;
using System;
using System.Threading.Tasks;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/Monument")]
    [ApiController]
    public class MonumentController : Controller
    {
        private readonly IMonumentServices _monumentServices;
        private readonly IMaterialServices _materialServices;
        private readonly IWorkerServices _workerServices;

        public MonumentController(IMonumentServices monumentServices, IMaterialServices materialServices, IWorkerServices workerServices)
        {
            _monumentServices = monumentServices;
            _materialServices = materialServices;
            _workerServices = workerServices;
        }

        // GET /Monument
        [HttpGet]
        public async Task<IActionResult> GetAllMonument()
        {
            try
            {
                var monumentDto = await _monumentServices.GetAllMonuments();
                return Ok(monumentDto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMonumentById(Guid id)
        {
            try
            {
                var monumentResult = await _monumentServices.GetMonumentById(id);
                return Ok(monumentResult);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateMonument([FromBody] MonumentRequest monument)
        {
            try
            {
                if (monument == null)
                {
                    return BadRequest("Monument object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _monumentServices.CreateMonument(monument);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateMonument(Guid id, [FromBody] MonumentRequest monument)
        {
            try
            {
                if (monument == null)
                {
                    return BadRequest("Monument object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }


                var monumentEntity = await _monumentServices.GetMonumentById(id);

                if (monumentEntity == null)
                {
                    return NotFound();
                }

                await _monumentServices.UpdateMonument(id, monument);
                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteMonument(Guid id)
        {
            try
            {

                var monumentEntity = await _monumentServices.GetMonumentById(id);

                if (monumentEntity == null)
                {
                    return NotFound();
                }

                await _monumentServices.DeleteMonument(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        //Monument
        [HttpPost("many/meterial")]
        [Authorize]
        public async Task<IActionResult> AddMaterial(MonumentRequest monument)
        {
            try
            {
                if (monument == null)
                {
                    return BadRequest("article object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }


                var articleEntity = await _monumentServices.GetMonumentById(monument.MonumentId);
                var materialEntity = await _materialServices.GetMaterialById(monument.MaterialId);

                if (articleEntity == null && materialEntity == null)
                {
                    return NotFound();
                }

                await _monumentServices.AddMaterial(monument.MonumentId, monument.MaterialId);
                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("many/meterial")]

        public async Task<IActionResult> GetAllMonumentByMaterial()
        {
            try
            {
                var monumentByMaterial = await _monumentServices.GetAllMaterialByMonument();
                return Ok(monumentByMaterial);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("many/meterial/{id}")]
        public async Task<IActionResult> GetMonumentByMaterial(Guid id)
        {
            try
            {
                var monumentEntity = await _monumentServices.GetMonumentById(id);

                if (monumentEntity == null)
                {
                    return NotFound();
                }
                var monumentByMaterial = await _monumentServices.GetMaterialByMonument(id);
                return Ok(monumentByMaterial);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }

        }

        [HttpPut("many/meterial/{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateMaterialByMonument(Guid id, [FromBody] MonumentRequest monument)
        {
            try
            {
                if (monument == null)
                {
                    return BadRequest("article object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }


                var monumentEntity = await _monumentServices.GetMonumentById(id);

                if (monumentEntity == null)
                {
                    return NotFound();
                }

                await _monumentServices.UpdateMaterialByMonument(id, monument);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpDelete("many/meterial/{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteMeterialByMonument(Guid id, [FromBody] MonumentRequest monument)
        {
            try
            {

                var articleEntity = await _monumentServices.GetMonumentById(id);

                if (articleEntity == null)
                {
                    return NotFound();
                }

                await _monumentServices.DeleteMaterialByMonument(id, monument);
                return Ok(articleEntity);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        //Worker
        [HttpPost("many/worker")]
        [Authorize]
        public async Task<IActionResult> AddWorker(MonumentRequest monument)
        {
            try
            {
                if (monument == null)
                {
                    return BadRequest("monument object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }

                var articleEntity = await _monumentServices.GetMonumentById(monument.MonumentId);
                var materialEntity = await _workerServices.GetWorkerById(monument.WorkerId);

                if (articleEntity == null && materialEntity == null)
                {
                    return NotFound();
                }

                await _monumentServices.AddWorker(monument.MonumentId, monument.WorkerId);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("many/worker")]
        public async Task<IActionResult> GetAllWorkerByMaterial()
        {
            try
            {
                var monumentByMaterial = await _monumentServices.GetAllWorkerByMonument();
                return Ok(monumentByMaterial);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("many/worker/{id}")]
        public async Task<IActionResult> GetWorkerByMaterial(Guid id)
        {
            try
            {
                var monumentEntity = await _monumentServices.GetMonumentById(id);

                if (monumentEntity == null)
                {
                    return NotFound();
                }
                var monumentByWorker = await _monumentServices.GetWorkerByMonument(id);
                return Ok(monumentByWorker);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }

        }

        [HttpPut("many/worker/{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateWorkerByMonument(Guid id, [FromBody] MonumentRequest monument)
        {
            try
            {
                if (monument == null)
                {
                    return BadRequest("worker object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("worker model object");
                }


                var monumentEntity = await _monumentServices.GetMonumentById(id);

                if (monumentEntity == null)
                {
                    return NotFound();
                }

                await _monumentServices.UpdateWorkerByMonument(id, monument);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpDelete("many/worker/{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteWorkerByMonument(Guid id, [FromBody] MonumentRequest monument)
        {
            try
            {

                var monumentEntity = await _monumentServices.GetMonumentById(id);

                if (monumentEntity == null)
                {
                    return NotFound();
                }

                await _monumentServices.DeleteWorkerByMonument(id, monument);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}