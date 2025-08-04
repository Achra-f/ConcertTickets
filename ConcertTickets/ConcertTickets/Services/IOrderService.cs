using ConcertTickets.Models;

namespace ConcertTickets.Services
{
    public interface IOrderService
    {
        int CreateOrder(OrderFormViewModel model);
        IEnumerable<OrderViewModel> GetOrdersByStatus(bool paid);
        OrderViewModel GetOrderById(int id);
        void UpdateOrder(int orderId, bool paid);
    }
}
