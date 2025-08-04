using Microsoft.AspNetCore.Identity;

namespace ConcertTickets.Data
{
    public class CustomUser : IdentityUser
    {
        [PersonalData]
        public string? FirstName { get; set; }

        [PersonalData]
        public string? LastName { get; set; }

        [PersonalData]
        public string? MemberCardNumber { get; set; }
    }
}
