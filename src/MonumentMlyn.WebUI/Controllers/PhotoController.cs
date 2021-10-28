using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

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
        public async Task<IActionResult> GetAllPhoto()
        {
            try
            {
                var photoDto = await _photoServices.GetAllPhotos();
                return Ok(photoDto);
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
        public async Task<IActionResult> CreatePhoto([FromBody] PhotoRequest photo)
        {
            try
            {
                if (photo == null)
                {
                    return BadRequest("Photo object is null");
                }

              
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _photoServices.CreatePhoto(photo);
                
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdatePhoto(Guid id, [FromBody] PhotoRequest photo)
        {
            try
            {
                if (photo == null)
                {
                    return BadRequest("Photo object is null");
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

                await _photoServices.UpdatePhoto(id, photo);
                return NoContent();

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
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}