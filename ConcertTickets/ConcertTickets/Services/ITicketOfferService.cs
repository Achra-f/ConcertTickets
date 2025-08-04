using ConcertTickets.Data;
using ConcertTickets.Models;
using ConcertTickets.Repositories;

namespace ConcertTickets.Services
{
    public interface ITicketOfferService
    {
        OrderFormViewModel GetTicketOfferForOrder(int id, bool hasMemberCard);
        void UpdateTicketOffer(TicketOfferUpdateViewModel model);
    }
}
