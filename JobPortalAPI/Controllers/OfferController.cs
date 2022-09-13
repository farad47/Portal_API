using Application.Dto.Offer;
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
        [SwaggerOperation(Summary = "Pobierz wszystkie oferty pracy.")]
        [HttpGet]
        public IActionResult Get()
        {
            var offers = _offerService.GetAllOffers();
            return Ok(offers);
        }
        [SwaggerOperation(Summary = "Pobierz ofertę pracy o unikalnym id.")]
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var offer = _offerService.GetOfferById(id);
            if (offer is null)
            {
                return NotFound();
            }
            return Ok(offer);
        }
        [SwaggerOperation(Summary = "Stwórz nową ofertę pracy")]
        [HttpPost]
        public IActionResult Add([FromBody] CreateOfferDto newOffer)
        {
            var offer = _offerService.AddOffer(newOffer);
            return Created($"Offer/{ offer.OfferId}",offer);
        }
        [SwaggerOperation(Summary = "Edytuj ofertę pracy.")]
        [HttpPut]
        public IActionResult Update([FromBody] UpdateOfferDto UpdateOffer)
        {
            _offerService.UpdateOffer(UpdateOffer);
            return NoContent();
        }
        [SwaggerOperation(Summary = "Usuń ofertę pracy.")]
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _offerService.DeleteOffer(id);
            return NoContent();
        }
    }
}
