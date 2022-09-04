using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IOfferRepository
    {
        IEnumerable<Offer> GetAllOffers();
        Offer GetById(int id);
        Offer Add(Offer offer);
        void Update(Offer offer);
        void Delete(Offer offer);
    }
}
