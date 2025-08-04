using ConcertTickets.Models;
using ConcertTickets.Repositories;

namespace ConcertTickets.Services
{
    public class ConcertService : IConcertService
    {
        private readonly IConcertRepository _concertRepository;

        public ConcertService(IConcertRepository concertRepository)
        {
            _concertRepository = concertRepository;
        }
        public IEnumerable<ConcertViewModel> GetAllConcerts()
        {
            var concerts = _concertRepository.GetConcertWithTicketOffers();

            var concertViewModel = concerts.Select(c => new ConcertViewModel
            {
                Id = c.Id,
                Artist = c.Artist,
                Location = c.Location,
                Date = c.Date,
                TicketOffer = c.TicketOffers.Select(to => new TicketOfferViewModel
                {
                    Id = to.Id,
                    TicketType = to.TicketType,
                    Price = to.Price,
                    NumTickets = to.NumTickets,
                }).ToList()
            });

            return concertViewModel;
        }

        public ConcertViewModel? GetConcertById(int id)
        {
            var concert = _concertRepository.GetConcertWithTicketOffers(id);

            if (concert == null)
            {
                return null;
            }

            var concertViewModel = new ConcertViewModel
            {
                Id = id,
                Artist = concert.Artist,
                Location = concert.Location,
                Date = concert.Date,
                TicketOffer = concert.TicketOffers.Select(to => new TicketOfferViewModel
                {
                    Id = to.Id,
                    TicketType = to.TicketType,
                    Price = to.Price,
                    NumTickets = to.NumTickets,
                }).ToList(),
            };

            return concertViewModel;
        }
    }
}
