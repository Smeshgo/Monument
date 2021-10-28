using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/Material")]

    [ApiController]
    public class MaterialController : Controller
    {
        private readonly IMaterialServices _materialServices;

        public MaterialController(IMaterialServices materialServices)
        {
            _materialServices = materialServices;
        }

        // GET /Material
        [HttpGet]
        public async Task<IActionResult> GetAllMaterial()
        {
            try
            {
                var materialDto = await _materialServices.GetAllMaterials();
                return Ok(materialDto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMaterialById(Guid id)
        {
            try
            {
                var materialResult = await _materialServices.GetMaterialById(id);
                return Ok(materialResult);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateMaterial([FromBody] MaterialRequest material)
        {
            try
            {
                if (material == null)
                {
                    return BadRequest("Material object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _materialServices.CreateMaterial(material);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateMaterial(Guid id, [FromBody] MaterialRequest material)
        {
            try
            {
                if (material == null)
                {
                    return BadRequest("Material object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }


                var materialEntity = await _materialServices.GetMaterialById(id);

                if (materialEntity == null)
                {
                    return NotFound();
                }

                await _materialServices.UpdateMaterial(id, material);
                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteMaterial(Guid id)
        {
            try
            {

                var materialEntity = await _materialServices.GetMaterialById(id);

                if (materialEntity == null)
                {
                    return NotFound();
                }

                await _materialServices.DeleteMaterial(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}