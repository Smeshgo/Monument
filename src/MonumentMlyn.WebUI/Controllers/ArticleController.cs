using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using MonumentMlyn.BLL.DTO.Article;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/Article")]
    [ApiController]
    public class ArticleController : Controller
    {
        private readonly IArticleServices _articleServices;
        private readonly IPhotoServices _photoServices;

        public ArticleController(IArticleServices articleServices, IPhotoServices photoServices)
        {
            _articleServices = articleServices;
            _photoServices = photoServices;
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
        [Authorize]
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
        [Authorize]
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
        [Authorize]
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
        [Authorize]
        [HttpPost("many")]
        public async Task<IActionResult> AddPhoto(ArticleRequest article)
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


                var articleEntity = await _articleServices.GetArticleById(article.ArticleId);
                var photoEntity = await _photoServices.GetPhotoById(article.PhotoId);

                if (articleEntity == null && photoEntity == null)
                {
                    return NotFound();
                }

                await _articleServices.AddPhoto(article.ArticleId, article.PhotoId);
                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("many/{id}")]
        public async Task<IActionResult> GetArticleByPhoto(Guid id)
        {
            try
            {
                var articleEntity = await _articleServices.GetArticleById(id);

                if (articleEntity == null)
                {
                    return NotFound();
                }
                var articleByPhoto = await _articleServices.GetPhotoByArticle(id);
                return Ok(articleByPhoto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
            
        }
        [HttpGet("many")]
        public async Task<IActionResult> GetAllArticleByPhoto()
        {
            try
            {
                var articleByPhoto = await _articleServices.GetAllPhotoByArticle();
                return Ok(articleByPhoto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
        [HttpPut("many/{id}")]
        [Authorize]
        public async Task<IActionResult> UpdatePhotoByArticle(Guid id, [FromBody] ArticleRequest article)
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

                await _articleServices.UpdatePhotoByArticle(id, article);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
        [HttpDelete("many/{id}")]
        [Authorize]
        public async Task<IActionResult> DeletePhotoByArticle(Guid id, [FromBody] ArticleRequest article)
        {
            try
            {

                var articleEntity = await _articleServices.GetArticleById(id);

                if (articleEntity == null)
                {
                    return NotFound();
                }

                await _articleServices.DeletePhotoByArticle(id, article);
                return Ok(articleEntity);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}