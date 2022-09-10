using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Offer
{
    public class OfferDto
    {
        public int OfferId { get; set; }
        public Company CompanyName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Remote { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public string ExpirationDate { get; set; }

    }
}
