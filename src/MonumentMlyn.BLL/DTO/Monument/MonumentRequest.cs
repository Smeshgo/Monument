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

        public MonumentRequest(decimal prise, Guid idPhoto, Guid idCustomer)
        {
            Prise = prise;
            IdPhoto = idPhoto;
            IdCustomer = idCustomer;
        }
        public decimal Prise { get; set; }
        public Guid IdPhoto { get; set; }
        public Guid IdCustomer { get; set; }
    }
}
