using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace JobPortalAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IOfferService _offerService;
        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var offers = _offerService.GetAllOffers();
            return Ok(offers);
        }
        [SwaggerOperation(Summary = "Stwórz nową ofertę pracy")]
        [HttpPost]
        public IActionResult Add(CreateOfferDto newOffer)
        {
            var offer = _offerService.AddOffer(newOffer);
            return Ok(offer);
        }
    }
}
