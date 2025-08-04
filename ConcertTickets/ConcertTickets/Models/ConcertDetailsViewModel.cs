namespace ConcertTickets.Models
{
    public class ConcertDetailsViewModel
    {
        public ConcertViewModel? Concert { get; set; }
        public List<TicketOfferViewModel>? TicketOffer { get; set; }
    }
}
