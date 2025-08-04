namespace ConcertTickets.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public int NumTickets { get; set; }
        public double TotalPrice { get; set; }
        public bool Paid { get; set; }
        public bool DiscountApplied { get; set; }
        public string? TicketType { get; set; }
        public string? ConcertArtist { get; set; }
        public string? ConcertLocation { get; set; }
        public DateTime ConcertDate { get; set; }
    }
}
