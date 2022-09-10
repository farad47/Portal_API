using Application.Dto.Offer;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;
        private readonly IMapper _mapper;
        public OfferService(IOfferRepository offerRepository,IMapper mapper)
        {
            _offerRepository = offerRepository;
            _mapper = mapper;
        }
        public IEnumerable<OfferDto> GetAllOffers()
        {
            var offer = _offerRepository.GetAllOffers();
            return _mapper.Map<IEnumerable<OfferDto>>(offer);
        }

        public OfferDto GetOfferById(int id)
        {
            var offer = _offerRepository.GetById(id);
            return _mapper.Map<OfferDto>(offer);
        }
        public OfferDto AddOffer(CreateOfferDto newOffer)
        {
            var offer = _mapper.Map<Offer>(newOffer);
            _offerRepository.Add(offer);
            return _mapper.Map<OfferDto>(offer);
        }
        public void UpdateOffer(UpdateOfferDto UpdateOffer)
        {
            var existingOffer = _offerRepository.GetById(UpdateOffer.OfferId);
            var offer = _mapper.Map(UpdateOffer, existingOffer);
            _offerRepository.Update(offer);

        }
        public void DeleteOffer(int id)
        {
            var offer = _offerRepository.GetById(id);
            _offerRepository.Delete(offer);
        }
    }
}
