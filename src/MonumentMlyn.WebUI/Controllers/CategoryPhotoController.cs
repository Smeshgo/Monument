using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;
using System;
using System.Threading.Tasks;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/CategoryPhoto")]
    [ApiController]
    public class CategoryPhotoController : Controller
    {
        private readonly ICategoryPhotoServices _categoryPhoto;

        public CategoryPhotoController(ICategoryPhotoServices categoryPhotoServices)
        {
            _categoryPhoto = categoryPhotoServices;
        }

        // GET /CategoryPhoto
        [HttpGet]
        public async Task<IActionResult> GetAllCategoryPhoto()
        {
            try
            {
                var categoryPhotoDto = await _categoryPhoto.GetAllCategoryPhoto();
                return Ok(categoryPhotoDto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryPhotoById(Guid id)
        {
            try
            {
                var categoryPhotoResult = await _categoryPhoto.GetCategoryPhotoById(id);
                return Ok(categoryPhotoResult);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategoryPhoto([FromBody] CategoryPhotoDto categoryPhoto)
        {
            try
            {
                if (categoryPhoto == null)
                {
                    return BadRequest("CategoryPhoto object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _categoryPhoto.CreateCategoryPhoto(categoryPhoto);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategoryPhoto(Guid id, [FromBody] CategoryPhotoDto categoryPhoto)
        {
            try
            {
                if (categoryPhoto == null)
                {
                    return BadRequest("CategoryPhoto object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }


                var categoryPhotoEntity = await _categoryPhoto.GetCategoryPhotoById(id);

                if (categoryPhotoEntity == null)
                {
                    return NotFound();
                }

                await _categoryPhoto.UpdateCategoryPhoto(id, categoryPhoto);
                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryPhoto(Guid id)
        {
            try
            {

                var categoryPhotoEntity = await _categoryPhoto.GetCategoryPhotoById(id);

                if (categoryPhotoEntity == null)
                {
                    return NotFound();
                }

                await _categoryPhoto.DeleteCategoryPhoto(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}