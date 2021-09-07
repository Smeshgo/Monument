using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MonumentMlyn.WebUI.Controllers
{
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("/errors")]
    public class GlobalErrorsController : Controller
    {
        
        // GET
        [HttpGet]
        [Route("errors/{statusCode}")]
        public IActionResult HendleErrors(int statusCode)
        {
            var contextException = HttpContext.Features.Get<IExceptionHandlerFeature>();
            switch (statusCode)
            {
                case 404:
                    return Ok("Posos");
                
            }
            return Problem(detail: contextException.Error.Message);
        }
    }
}