using ConcertTickets.Models;
using ConcertTickets.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConcertTickets.Controllers
{
    public class ConcertController : Controller
    {
        private readonly IConcertService _concertService;
        private readonly ITicketOfferService _ticketOfferService;

        public ConcertController(IConcertService concertService, ITicketOfferService ticketOfferService)
        {
            _concertService = concertService;
            _ticketOfferService = ticketOfferService;
        }
        public IActionResult Index()
        {
            var concerts = _concertService.GetAllConcerts();
            return View(concerts);
        }

        public IActionResult Buy(int id)
        {
            var concert = _concertService.GetConcertById(id);
            if (concert == null)
            {
                return NotFound();
            }

            var viewModel = new ConcertDetailsViewModel
            {
                Concert = concert,
                TicketOffer = concert.TicketOffer?.Select(t => new TicketOfferViewModel
                {
                    Id = t.Id,
                    TicketType = t.TicketType,
                    Price = t.Price,
                    NumTickets = t.NumTickets
                }).ToList()
            };

            return View(viewModel);
        }
    }
}
