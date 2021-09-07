using System;
using System.ComponentModel.DataAnnotations;
using MonumentMlyn.DAL.Enum;

namespace MonumentMlyn.BLL.DTO
{
    public class PhotoRequest
    {
        public PhotoRequest()
        {
            
        }

        public PhotoRequest(string name, string pathFull, string pathMini, CategoryPhoto categoryPhoto)
        {
            Name = name;
            PathFull = pathFull;
            PathMini = pathMini;
            CategoryPhoto = categoryPhoto;
        }

        [Required] public string Name { get; set; }
        [Required] public string PathFull { get; set; }
        [Required] public string PathMini { get; set; }
        public CategoryPhoto CategoryPhoto { get; set; }

    }
}