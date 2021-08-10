using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class MonumentWorkerDTO
    {
        public Guid IdMonument { get; set; }
        public Guid IdWorker { get; set; }

        public virtual MonumentDTO IdMonumentNavigation { get; set; }
        public virtual WorkerDTO IdWorkerNavigation { get; set; }
    }
}
