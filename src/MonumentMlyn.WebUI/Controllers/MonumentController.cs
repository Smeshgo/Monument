using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;
using System;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO.Monument;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/Monument")]
    [ApiController]
    public class MonumentController : Controller
    {
        private readonly IMonumentServices _monumentServices;
        private readonly IMaterialServices _materialServices;

        public MonumentController(IMonumentServices monumentServices, IMaterialServices materialServices)
        {
            _monumentServices = monumentServices;
            _materialServices = materialServices;
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
        [HttpPost("many")]
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

        [HttpGet("many")]
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

        [HttpGet("many/{id}")]
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

        [HttpPut("many/{id}")]
        public async Task<IActionResult> UpdatePhotoByArticle(Guid id, [FromBody] MonumentRequest monument)
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

        [HttpDelete("many/{id}")]
        public async Task<IActionResult> DeletePhotoByArticle(Guid id, [FromBody] MonumentRequest monument)
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
    }
}