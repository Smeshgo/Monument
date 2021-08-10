using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class MonumentDTO
    {
        public MonumentDTO()
        {
            MaterialMonuments = new HashSet<MaterialMonumentDTO>();
            MonumentWorkers = new HashSet<MonumentWorkerDTO>();
        }

        public Guid IdMonument { get; set; }
        public decimal Prise { get; set; }
        public Guid IdPhoto { get; set; }
        public Guid Id_customer { get; set; }

        public virtual PhotoDTO IdPhotoNavigation { get; set; }
        public virtual ICollection<MaterialMonumentDTO> MaterialMonuments { get; set; }
        public virtual ICollection<MonumentWorkerDTO> MonumentWorkers { get; set; }
    }
}
