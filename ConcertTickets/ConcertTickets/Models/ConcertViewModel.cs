using ConcertTickets.Data;

namespace ConcertTickets.Models
{
    public class ConcertViewModel
    {
        public int Id { get; set; }
        public string? Artist { get; set; }
        public string? Location { get; set; }
        public DateTime Date { get; set; }
        public int AvailableTickets => TicketOffer?.Sum(t => t.NumTickets) ?? 0;
        public List<TicketOfferViewModel>? TicketOffer { get; set; }
        // Voornaam Naam => VoornaamNaam.png string manipulatie
        public string ArtistImg => $"/img/{Artist.Replace(" ", "")}.png";
        // Gepaste labels
        public string TicketButtonLabel
        {
            get
            {
                if (AvailableTickets == 0) return "Uitverkocht";
                if (AvailableTickets <= 500) return "Laatste tickets!";
                return "Koop tickets";
            }
        }
        // Gepaste boostrap class
        public string TicketButtonClass
        {
            get
            {
                if (AvailableTickets == 0) return "btn btn-danger";
                if (AvailableTickets <= 500) return "btn btn-outline-warning";
                return "btn btn-outline-primary";
            }
        }
    }
}
