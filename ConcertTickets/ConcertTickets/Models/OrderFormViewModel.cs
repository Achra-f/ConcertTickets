using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ConcertTickets.Helper;

namespace ConcertTickets.Models
{
    public class OrderFormViewModel
    {
        [ValidateNever]
        public string? UserId { get; set; }

        [ValidateNever]
        public string? UserName { get; set; }
        [ValidateNever]
        public string? TicketType { get; set; }
        [ValidateNever]
        public double Price { get; set; }
        [ValidateNever]
        public int AvailableTickets { get; set; }

        [Required(ErrorMessage = "Aantal tickets is verplicht")]
        [Range(1, 5, ErrorMessage = "Het aantal tickets moet tussen 1 en 5 zijn")]
        [Display(Name = "Aantal tickets")]
        public int TotalTickets { get; set; }

        [CheckBoxRequired]
        public bool TermsOfService { get; set; }

        [ValidateNever]
        public int TicketOfferId { get; set; }

        [ValidateNever]
        public ConcertViewModel? Concert { get; set; }
        [ValidateNever]
        public bool HasMemberCard { get; set; }
    }
}
