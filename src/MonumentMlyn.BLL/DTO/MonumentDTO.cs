using System;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class MonumentDto
    {
        public MonumentDto()
        {

        }
        public MonumentDto(Guid idMonument, decimal prise, Guid idPhoto, Guid idCustomer, PhotoDto photo)
        {
            this.IdMonument = idMonument;
            this.Prise = prise;
            this.IdPhoto = idPhoto;
            this.Photo = photo;
        }

        public Guid IdMonument { get; set; }
        public decimal Prise { get; set; }
        public Guid IdPhoto { get; set; }
        public Guid IdCustomer { get; set; }

        public PhotoDto Photo { get; set; }

    }
}
