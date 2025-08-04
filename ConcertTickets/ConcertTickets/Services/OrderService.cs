using System.Security.Claims;
using ConcertTickets.Data;
using ConcertTickets.Models;
using ConcertTickets.Repositories;
using Microsoft.AspNetCore.Identity;

namespace ConcertTickets.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ITicketOfferRepository _ticketOfferRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<CustomUser> _userManager;

        public OrderService(IOrderRepository orderRepository, ITicketOfferRepository ticketOfferRepository, IHttpContextAccessor httpContextAccessor, UserManager<CustomUser> userManager)
        {
            _orderRepository = orderRepository;
            _ticketOfferRepository = ticketOfferRepository;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }
        public int CreateOrder(OrderFormViewModel model)
        {
            var ticketOffer = _ticketOfferRepository.GetTicketOfferById(model.TicketOfferId);
            if (ticketOffer == null)
            {
                throw new Exception("Ticket niet gevonden");
            }

            // Neem user van sessie
            var userId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = _userManager.FindByIdAsync(userId).Result;

            // Bereken totale prijs
            var totalPrice = model.TotalTickets * ticketOffer.Price;

            // Bepaal korting
            bool discountApplied = false;
            if (!string.IsNullOrEmpty(user.MemberCardNumber))
            {
                totalPrice *= 0.9;
                discountApplied = true;
            }

            var order = new Order
            {
                UserId = userId,
                UserName = user.UserName,
                NumTickets = model.TotalTickets,
                TotalPrice = totalPrice,
                Paid = false,
                DiscountApplied = discountApplied,
                TicketOfferId = ticketOffer.Id,
            };

            _orderRepository.Add(order);
            _orderRepository.SaveChanges();
            return order.Id;
        }

        public OrderViewModel GetOrderById(int id)
        {
            var order = _orderRepository.GetOrderById(id);

            if (order == null)
            {
                throw new Exception("Ticket niet gevonden");
            }

            // Toon order na bestelling
            return new OrderViewModel
            {
                Id = order.Id,
                OrderId = order.Id,
                UserId = order.UserId,
                UserName = order.UserName,
                NumTickets = order.NumTickets,
                TotalPrice = order.TotalPrice,
                Paid = order.Paid,
                DiscountApplied = order.DiscountApplied,
                TicketType = order.TicketOffer?.TicketType,
                ConcertLocation = order.TicketOffer?.Concert?.Location,
                ConcertDate = order.TicketOffer?.Concert?.Date ?? DateTime.Now
            }; 
        }

        public IEnumerable<OrderViewModel> GetOrdersByStatus(bool paid)
        {
            var orders = _orderRepository.GetOrdersByStatus(paid);

            // Toon lijst van alle orders
            return orders.Select(order => new OrderViewModel
            {
                Id = order.Id,
                OrderId = order.Id,
                UserId = order.UserId,
                UserName = order.UserName,
                NumTickets = order.NumTickets,
                TotalPrice = order.TotalPrice,
                Paid = order.Paid,
                TicketType = order.TicketOffer?.TicketType,
                ConcertArtist = order.TicketOffer?.Concert?.Artist ?? "Onbekend",
                ConcertLocation = order.TicketOffer?.Concert?.Location ?? "Onbekend",
                ConcertDate = order.TicketOffer?.Concert?.Date ?? DateTime.Now,
                DiscountApplied = order.DiscountApplied
            }).ToList();
        }

        public void UpdateOrder(int orderId, bool paid)
        {
            var order = _orderRepository.GetOrderById(orderId);

            order.Paid = paid;
            _orderRepository.Update(order);
            _orderRepository.SaveChanges();
        }
    }
}
