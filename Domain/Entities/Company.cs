using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Company : AuditableEntity
    {
        public int CompanyId { get; set; }
        [Required]
        public string CompanyName { get; set; }
    }
}
