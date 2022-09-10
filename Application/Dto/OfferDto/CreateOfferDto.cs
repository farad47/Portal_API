using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Offer
{
    public class CreateOfferDto
    {
        public int CompanyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Remote { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public string ExpirationDate { get; set; }
    }
}
