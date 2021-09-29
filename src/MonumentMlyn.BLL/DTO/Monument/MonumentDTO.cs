using System;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class MonumentDto
    {
        public MonumentDto()
        {

        }

        public MonumentDto(Guid monumentId, decimal prise, Guid photoId, Guid idCustomer)
        {
            MonumentId = monumentId;
            Prise = prise;
            PhotoId = photoId;
            IdCustomer = idCustomer;
        }

        public Guid MonumentId { get; set; }
        public decimal Prise { get; set; }
        public Guid PhotoId { get; set; }
        public Guid IdCustomer { get; set; }

        

    }
}
