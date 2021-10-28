using System;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.DTO.ArticlePhoto
{
    public class ArticlePhotoDTO
    {
        public ArticlePhotoDTO()
        {
            
        }

        public ArticlePhotoDTO(Guid photoId, Guid articleId)
        {
            PhotoId = photoId;
            ArticleId = articleId;
        }
        public Guid PhotoId { get; set; }
        public Guid ArticleId { get; set; }
    }
}