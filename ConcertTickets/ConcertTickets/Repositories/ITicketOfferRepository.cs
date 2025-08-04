using ConcertTickets.Data;

namespace ConcertTickets.Repositories
{
    public interface ITicketOfferRepository : IRepository<TicketOffer>
    {
        TicketOffer GetTicketOfferById(int id);
    }
}
