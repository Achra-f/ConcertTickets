using ConcertTickets.Data;
using Microsoft.EntityFrameworkCore;

namespace ConcertTickets.Repositories
{
    public class TicketOfferRepository : Repository<TicketOffer>, ITicketOfferRepository
    {
        public TicketOfferRepository(ApplicationDbContext context) : base(context) { }

        public TicketOffer GetTicketOfferById(int id)
        {
            return _context.TicketOffers
                .Include(t => t.Concert)
                .ThenInclude(c => c.TicketOffers)
                .FirstOrDefault(to => to.Id == id);
        }
    }
}
