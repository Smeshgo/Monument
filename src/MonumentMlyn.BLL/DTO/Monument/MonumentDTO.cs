using System;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class MonumentDto
    {
        public MonumentDto()
        {

        }

        public MonumentDto(Guid idMonument, decimal prise, Guid idPhoto, Guid idCustomer)
        {
            IdMonument = idMonument;
            Prise = prise;
            IdPhoto = idPhoto;
            IdCustomer = idCustomer;
        }

        public Guid IdMonument { get; set; }
        public decimal Prise { get; set; }
        public Guid IdPhoto { get; set; }
        public Guid IdCustomer { get; set; }

        

    }
}
