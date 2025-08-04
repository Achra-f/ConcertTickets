using ConcertTickets.Models;
using ConcertTickets.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ConcertTickets.Services
{
    public class TicketOfferService : ITicketOfferService
    {
        private readonly ITicketOfferRepository _ticketOfferRepository;

        public TicketOfferService(ITicketOfferRepository ticketOfferRepository)
        {
            _ticketOfferRepository = ticketOfferRepository;
        }

        public OrderFormViewModel GetTicketOfferForOrder(int id, bool hasMemberCard)
        {
            var ticketOffer = _ticketOfferRepository
            .GetTicketOfferById(id);

            if (ticketOffer == null)
                return null;

            var concert = new ConcertViewModel
            {
                Id = ticketOffer.Concert.Id,
                Artist = ticketOffer.Concert.Artist,
                Location = ticketOffer.Concert.Location,
                Date = ticketOffer.Concert.Date,
                TicketOffer = ticketOffer.Concert.TicketOffers?.Select(t => new TicketOfferViewModel
                {
                    Id = t.Id,
                    TicketType = t.TicketType,
                    Price = t.Price,
                    NumTickets = t.NumTickets
                }).ToList()
            };

            return new OrderFormViewModel
            {
                TicketType = ticketOffer.TicketType,
                Price = hasMemberCard ? ticketOffer.Price * 0.9 : ticketOffer.Price,
                AvailableTickets = ticketOffer.NumTickets,
                TicketOfferId = ticketOffer.Id,
                Concert = concert
            };
        }

        public void UpdateTicketOffer(TicketOfferUpdateViewModel model)
        {
            var ticketOffer = _ticketOfferRepository.GetTicketOfferById(model.Id);
            if (ticketOffer != null)
            {
                ticketOffer.NumTickets -= model.TotalTickets;
                _ticketOfferRepository.SaveChanges();
            }
        }
    }
}
