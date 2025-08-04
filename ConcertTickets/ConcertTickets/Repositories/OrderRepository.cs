using ConcertTickets.Data;
using Microsoft.EntityFrameworkCore;

namespace ConcertTickets.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context) { }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders
                .Include(o => o.TicketOffer)
                .ThenInclude(to => to.Concert)
                .FirstOrDefault(o => o.Id == orderId);

        }

        public IEnumerable<Order> GetOrdersByStatus(bool paid)
        {
            return _context.Orders
                .Include(o => o.TicketOffer)
                .ThenInclude(to => to.Concert)
                .Where(order => order.Paid == paid)
                .ToList();
        }
    }
}
