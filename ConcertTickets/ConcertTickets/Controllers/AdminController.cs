using ConcertTickets.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ConcertTickets.Controllers
{
    [Authorize(Policy = "AdminOnly")]
    public class AdminController : Controller
    {
        private readonly IOrderService _orderService;

        public AdminController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Orders()
        {
            var unPaidOrders = _orderService.GetOrdersByStatus(false);
            return View(unPaidOrders);
        }

        public IActionResult SetPaid(int orderId)
        {
            _orderService.UpdateOrder(orderId, true);
            return RedirectToAction(nameof(Orders));
        }
    }
}
