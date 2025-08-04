using ConcertTickets.Data;
using Microsoft.EntityFrameworkCore;

namespace ConcertTickets.Repositories
{
    public class ConcertRepository : IConcertRepository
    {
        private readonly ApplicationDbContext _context;

        public ConcertRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Concert> GetConcertWithTicketOffers()
        {
            return _context.Concerts
                .Include(c => c.TicketOffers)
                .ToList();
        }

        public Concert GetConcertWithTicketOffers(int id)
        {
            return _context.Concerts
                .Include (c => c.TicketOffers)
                .FirstOrDefault(c => c.Id == id);
        }
    }
}
