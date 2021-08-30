using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO.CategoryPhoto
{
  public  class CategoryPhotoRequest
    {
        public CategoryPhotoRequest()
        {
            
        }

        public CategoryPhotoRequest(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

    }
}
