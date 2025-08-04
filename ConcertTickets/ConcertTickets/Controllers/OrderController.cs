using ConcertTickets.Data;
using ConcertTickets.Models;
using ConcertTickets.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ConcertTickets.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly UserManager<CustomUser> _userManager;
        private readonly ITicketOfferService _ticketOfferService;
        private readonly IOrderService _orderService;

        public OrderController(UserManager<CustomUser> userManager, ITicketOfferService ticketOfferService, IOrderService orderService)
        {
            _userManager = userManager;
            _ticketOfferService = ticketOfferService;
            _orderService = orderService;
        }
        public async Task<IActionResult> Create(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound("Gebruiker niet gevonden");
            }

            // Check voor lidkaart
            bool hasMemberCard = !string.IsNullOrEmpty(user.MemberCardNumber);
            var viewModel = _ticketOfferService.GetTicketOfferForOrder(id, hasMemberCard);

            // Geef info aan de view (lidkaart)
            viewModel.HasMemberCard = hasMemberCard;

            if (viewModel == null)
            {
                return NotFound("Ticket niet gevonden");
            }

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrderFormViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);

            if (!ModelState.IsValid)
            {
                // Check voor lidkaart
                bool hasMemberCard = !string.IsNullOrEmpty(user.MemberCardNumber);
                var updatedViewModel = _ticketOfferService.GetTicketOfferForOrder(model.TicketOfferId, hasMemberCard);

                if (updatedViewModel == null)
                {
                    return NotFound("Ticket niet gevonden");
                }

                // Update the tickers info
                updatedViewModel.TotalTickets = model.TotalTickets;
                updatedViewModel.TermsOfService = model.TermsOfService;

                return View(updatedViewModel);
            }

            // Zoek naam van User voor order
            model.UserId = user.Id;
            model.UserName = user.UserName;

            var orderId =  _orderService.CreateOrder(model);
            var updateModel = new TicketOfferUpdateViewModel
            {
                // Prijs na korting
                Id = model.TicketOfferId,
                TotalTickets = model.TotalTickets
            };
            _ticketOfferService.UpdateTicketOffer(updateModel);

            // Geef order info mee naar success pagina
            return RedirectToAction(nameof(Success), new { id = orderId });
        }

        public IActionResult Success(int id)
        {
            var orderViewModel = _orderService.GetOrderById(id);
            if (orderViewModel == null)
            {
                return NotFound("Order niet gevonden");
            }
            return View(orderViewModel);

        }
    }
}
