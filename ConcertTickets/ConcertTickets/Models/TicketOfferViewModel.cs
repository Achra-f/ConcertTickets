using System.Security;

namespace ConcertTickets.Models
{
    public class TicketOfferViewModel
    {
        public int Id { get; set; }
        public string? TicketType { get; set; }
        public double Price { get; set; }
        public int NumTickets { get; set; }
    }
}
