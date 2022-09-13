using Application.Dto.CompanyDto;
using Application.Dto.Offer;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Offer, OfferDto>();
                cfg.CreateMap<CreateOfferDto, Offer>().ForPath(x => x.CompanyName.CompanyId, m => m.MapFrom(s => s.CompanyId));
                cfg.CreateMap<UpdateOfferDto, Offer>();
                cfg.CreateMap<Company, CompanyDto>();
                cfg.CreateMap<AddCompanyDto, Company>();
            }).CreateMapper();
    }
}
//.ForMember(x => x.CompanyName.CompanyId, m => m.MapFrom(s => s.CompanyId));