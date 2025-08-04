using ConcertTickets.Data;

namespace ConcertTickets.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetOrdersByStatus(bool paid);
        Order GetOrderById(int orderId);
    }
}
