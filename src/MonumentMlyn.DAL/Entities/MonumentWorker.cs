using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class MonumentWorker
    {
        [Key]
        public Guid IdMonument { get; set; }
        public Guid IdWorker { get; set; }


        public virtual Monument IdMonumentNavigation { get; set; }
        public virtual Worker IdWorkerNavigation { get; set; }
    }
}
