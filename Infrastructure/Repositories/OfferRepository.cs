using Domain.Entities;
using Domain.Entities.Common;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly ApplicationDbContext _context; 
        public OfferRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public IEnumerable<Offer> GetAllOffers()
        {
            return _context.Offer.ToList();
        }
        public Offer GetById(int id)
        {
            return _context.Offer.SingleOrDefault(x => x.OfferId == id);
        }
        public Offer Add(Offer offer)
        {
            throw new NotImplementedException();
        }
        public void Update(Offer offer)
        {
            throw new NotImplementedException();
        }
        public void Delete(Offer offer)
        {
            throw new NotImplementedException();
        }
    }
}
