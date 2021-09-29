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

        public MonumentRequest(decimal prise, Guid photoId, Guid idCustomer)
        {
            Prise = prise;
            PhotoId = photoId;
            IdCustomer = idCustomer;
        }
        public decimal Prise { get; set; }
        public Guid PhotoId { get; set; }
        public Guid IdCustomer { get; set; }
    }
}
