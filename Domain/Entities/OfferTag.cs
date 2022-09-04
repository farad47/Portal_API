using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OfferTag : AuditableEntity
    {
        public int OfferTagId { get; set; }
        [Required]
        public Offer Offer { get; set; }
        [Required]
        public Tag tag { get; set; }
    }
}
