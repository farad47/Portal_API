using Application.Dto;
using Application.Interfaces;
using AutoMapper;
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
    }
}
