using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Offer : AuditableEntity
    {
        public int OfferId { get; set; }
        [Required]
        public Company CompanyName { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool Remote { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string ExpirationDate { get; set; }
    }
}
