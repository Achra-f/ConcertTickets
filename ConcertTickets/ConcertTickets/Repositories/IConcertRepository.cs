using ConcertTickets.Data;

namespace ConcertTickets.Repositories
{
    public interface IConcertRepository
    {
        IEnumerable<Concert> GetConcertWithTicketOffers();
        Concert GetConcertWithTicketOffers(int id);
    }
}
