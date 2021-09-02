using System;
using MonumentMlyn.DAL.Enum;

namespace MonumentMlyn.BLL.DTO
{
    public class PhotoRequest
    {
        public PhotoRequest()
        {
            
        }

        public PhotoRequest(string name, string pathFull, string pathMini, string path, CategoryPhoto categoryPhoto)
        {
            Name = name;
            PathFull = pathFull;
            PathMini = pathMini;
            this.path = path;
            CategoryPhoto = categoryPhoto;
        }

        public string Name { get; set; }
        public string PathFull { get; set; }
        public string PathMini { get; set; }
        public string path { get; set; }
        public CategoryPhoto CategoryPhoto { get; set; }

    }
}