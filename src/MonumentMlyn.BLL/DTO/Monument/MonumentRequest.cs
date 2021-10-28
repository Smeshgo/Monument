using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO.Monument
{
    public class MonumentRequest
    {
        public MonumentRequest()
        {
            
        }

        public MonumentRequest(Guid monumentId, decimal price, Guid photoId, Guid customerId, Guid materialId, Guid materialIdOld, Guid workerId, Guid workerIdOld)
        {
            MonumentId = monumentId;
            Price = price;
            PhotoId = photoId;
            CustomerId = customerId;
            MaterialId = materialId;
            MaterialIdOld = materialIdOld;
            WorkerId = workerId;
            WorkerIdOld = workerIdOld;
        }
        public Guid MonumentId { get; set; }
        public decimal Price { get; set; }
        public Guid PhotoId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid MaterialId { get; set; }
        public Guid MaterialIdOld { get; set; }
        public Guid WorkerId { get; set; }
        public Guid WorkerIdOld { get; set; }

    }
}
