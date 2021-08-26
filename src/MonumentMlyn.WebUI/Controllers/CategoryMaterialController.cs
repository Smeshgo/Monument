using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;
using System;
using System.Threading.Tasks;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/CategoryPhoto")]
    [ApiController]
    public class CategoryMaterialController : Controller
    {
        private readonly ICategoryMaterialServices _categoryMaterial;

        public CategoryMaterialController(ICategoryMaterialServices categoryMaterialServices)
        {
            _categoryMaterial = categoryMaterialServices;
        }

        // GET /CategoryMaterial
        [HttpGet]
        public async Task<IActionResult> GetAllCategoryMaterial()
        {
            try
            {
                var categoryPhotoDto = await _categoryMaterial.GetAllCategoryMaterial();
                return Ok(categoryPhotoDto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryMaterialById(Guid id)
        {
            try
            {
                var articleResult = await _categoryMaterial.GetCategoryMaterialById(id);
                return Ok(articleResult);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategoryMaterial([FromBody] CategoryMaterialDto categoryMaterial)
        {
            try
            {
                if (categoryMaterial == null)
                {
                    return BadRequest("categoryMaterial object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _categoryMaterial.CreateCategoryMaterial(categoryMaterial);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategoryMaterial(Guid id, [FromBody] CategoryMaterialDto categoryMaterial)
        {
            try
            {
                if (categoryMaterial == null)
                {
                    return BadRequest("categoryMaterial object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }


                var categoryMaterialEntity = await _categoryMaterial.GetCategoryMaterialById(id);

                if (categoryMaterialEntity == null)
                {
                    return NotFound();
                }

                await _categoryMaterial.UpdateCategoryMaterial(id, categoryMaterial);
                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryMaterial(Guid id)
        {
            try
            {

                var categoryMaterialEntity = await _categoryMaterial.GetCategoryMaterialById(id);

                if (categoryMaterialEntity == null)
                {
                    return NotFound();
                }

                await _categoryMaterial.DeleteCategoryMaterial(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}