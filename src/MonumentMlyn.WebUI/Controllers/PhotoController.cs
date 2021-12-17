using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using MonumentMlyn.BLL.DTO.Paging;
using Newtonsoft.Json;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/Photo")]

    [ApiController]
    public class PhotoController : Controller
    {
        private readonly IPhotoServices _photoServices;

        public PhotoController(IPhotoServices photoServices)
        {
            _photoServices = photoServices;
        }

        // GET /Photo
        [HttpGet]
        public async Task<IActionResult> GetAllPhoto([FromQuery] OwnerParameters ownerParameters)
        {
            try
            {
                var photoDto = await _photoServices.GetAllPhotos(ownerParameters);

                var metadata = new
                {
                    photoDto.TotalCount,
                    photoDto.PageSize,
                    photoDto.CurrentPage,
                    photoDto.HasNext,
                    photoDto.HasPrevious
                };
                Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
                return Ok(photoDto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
        [HttpGet("category")]
        public async Task<IActionResult> GetCategoryId([FromQuery] int category, [FromQuery]OwnerParameters ownerParameters)
        {
            try
            {
                var photoResult = await _photoServices.GetAllMinyPhoto(category, ownerParameters);
                var metadata = new
                {
                    photoResult.TotalCount,
                    photoResult.PageSize,
                    photoResult.CurrentPage,
                    photoResult.HasNext,
                    photoResult.HasPrevious
                };
                Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
                return Ok(photoResult);

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPhotoById(Guid id)
        {
            try
            {
                var photoResult = await _photoServices.GetPhotoById(id);
                return Ok(photoResult);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreatePhoto(IFormFile imgFull, IFormFile imgMini, string name, int category)
        {
            try
            {
                if (name == null || category is <= 0 or >= 7)
                {
                    return BadRequest("Category not correct");
                }

                if (imgFull == null && imgMini == null)
                {
                    return StatusCode(404,"Not Img file");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _photoServices.CreatePhoto(imgFull, imgMini, name, category);



                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdatePhoto(Guid id,IFormFile imgFull, IFormFile imgMini, string name, int category)
        {
            try
            {
                if (name == null || category is <= 1 or >= 6)
                {
                    return BadRequest("Category not correct");
                }

                if (imgFull == null && imgMini == null)
                {
                    return StatusCode(404, "Not Img file");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }


                var photoEntity = await _photoServices.GetPhotoById(id);

                if (photoEntity == null)
                {
                    return NotFound();
                }

                await _photoServices.UpdatePhoto( id,  imgFull,  imgMini,  name,  category);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeletePhoto(Guid id)
        {
            try
            {

                var photoEntity = await _photoServices.GetPhotoById(id);

                if (photoEntity == null)
                {
                    return NotFound();
                }

                await _photoServices.DeletePhoto(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}