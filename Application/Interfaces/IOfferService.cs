﻿using Application.Dto;
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

    }
}
