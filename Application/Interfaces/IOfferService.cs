using Application.Dto.Offer;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOfferService
    {
        IEnumerable<OfferDto> GetAllOffers();
        OfferDto GetOfferById(int id);
        OfferDto AddOffer(CreateOfferDto offer);
        void UpdateOffer(UpdateOfferDto offer);
        void DeleteOffer(int id);

    }
}
