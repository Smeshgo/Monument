using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Monument
    {
        public Monument()
        {
            MaterialMonuments = new HashSet<MaterialMonument>();
            MonumentWorkers = new HashSet<MonumentWorker>();
        }
        [Key]
        public Guid IdMonument { get; set; }
        public decimal Prise { get; set; }
        public Guid IdPhoto { get; set; }
        public Guid Id_customer { get; set; }

        public virtual Photo IdPhotoNavigation { get; set; }
        public virtual ICollection<MaterialMonument> MaterialMonuments { get; set; }
        public virtual ICollection<MonumentWorker> MonumentWorkers { get; set; }
    }
}
