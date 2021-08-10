using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class MaterialMonumentDTO
    {
        public Guid IdMaterialMonument { get; set; }
        public Guid IdMonument { get; set; }
        public Guid IdMaterial { get; set; }

        public virtual MaterialDTO IdMaterialNavigation { get; set; }
        public virtual MonumentDTO IdMonumentNavigation { get; set; }
    }
}
