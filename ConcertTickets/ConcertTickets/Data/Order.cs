namespace ConcertTickets.Data
{
    public class Order : BaseEntity
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public int NumTickets { get; set; }
        public double TotalPrice { get; set; }
        public bool Paid { get; set; } = false;
        public bool DiscountApplied { get; set; } = false;
        public int TicketOfferId { get; set; }
        public TicketOffer? TicketOffer { get; set; }
    }
}
