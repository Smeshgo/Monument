using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;
using System;
using System.Threading.Tasks;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/Role")]

    [ApiController]
    public class RoleController : Controller
    {
        private readonly IRoleServices _roleServices;

        public RoleController(IRoleServices roleServices)
        {
            _roleServices = roleServices;
        }

        // GET /Role
        [HttpGet]
        public async Task<IActionResult> GetAllRole()
        {
            try
            {
                var roleDto = await _roleServices.GetAllRoles();
                return Ok(roleDto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleById(Guid id)
        {
            try
            {
                var roleResult = await _roleServices.GetRoleById(id);
                return Ok(roleResult);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] RoleDto role)
        {
            try
            {
                if (role == null)
                {
                    return BadRequest("Role object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _roleServices.CreateRole(role);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRole(Guid id, [FromBody] RoleDto role)
        {
            try
            {
                if (role == null)
                {
                    return BadRequest("Role object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }


                var roleEntity = await _roleServices.GetRoleById(id);

                if (roleEntity == null)
                {
                    return NotFound();
                }

                await _roleServices.UpdateRole(id, role);
                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(Guid id)
        {
            try
            {

                var roleEntity = await _roleServices.GetRoleById(id);

                if (roleEntity == null)
                {
                    return NotFound();
                }

                await _roleServices.DeleteRole(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}