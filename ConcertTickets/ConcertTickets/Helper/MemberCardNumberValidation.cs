using System.ComponentModel.DataAnnotations;

namespace ConcertTickets.Helper
{
    public class MemberCardNumberValidation : ValidationAttribute
    {
        private readonly string _errorMessage;
        public MemberCardNumberValidation(string errorMessage)
        {
            _errorMessage = errorMessage;
        }

        public override bool IsValid(object? value)
        {
            // Mag NULL of leeg zijn
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return true;
            }

            var memberCardNumber = value.ToString();

            // Check als string met "ODI" begint & ook 13 karakters lang is.
            if (memberCardNumber.Length == 13 && memberCardNumber.StartsWith("ODI") )
            {
                // Laatste 10 moeten cijfers zijn
                if (long.TryParse(memberCardNumber.Substring(3), out _))
                {
                    return true;
                }
            }

            ErrorMessage = _errorMessage;
            return false;
        }
    }
}
