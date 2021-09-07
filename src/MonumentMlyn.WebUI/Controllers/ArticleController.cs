using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;
using System;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO.Article;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/Article")]
    [ApiController]
    public class ArticleController : Controller
    {
        private readonly IArticleServices _articleServices;

        public ArticleController(IArticleServices articleServices)
        {
            _articleServices = articleServices;
        }

        // GET /Article
        [HttpGet]
        public async Task<IActionResult> GetAllArticle()
        {
            try
            {
                var articleDto = await _articleServices.GetAllArticles();
                return Ok(articleDto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleById(Guid id)
        {
            try
            {
                var articleResult = await _articleServices.GetArticleById(id);
                return Ok(articleResult);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticle([FromBody] ArticleRequest article)
        {
            try
            {
                if (article == null)
                {
                    return BadRequest("Article object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _articleServices.CreateArticle(article);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateArticle(Guid id, [FromBody] ArticleRequest article)
        {
            try
            {
                if (article == null)
                {
                    return BadRequest("article object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }


                var articleEntity = await _articleServices.GetArticleById(id);

                if (articleEntity == null)
                {
                    return NotFound();
                }

                await _articleServices.UpdateArticle(id, article);
                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(Guid id)
        {
            try
            {

                var articleEntity = await _articleServices.GetArticleById(id);

                if (articleEntity == null)
                {
                    return NotFound();
                }

                await _articleServices.DeleteArticle(id);
                return Ok(articleEntity);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}