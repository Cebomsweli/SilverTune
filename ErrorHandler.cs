using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverTune
{
    class ErrorHandler
    {
        //verify email
        public bool ValidateEmail(string email)
        {

            // Accepts only gmail.com or gmail.ac.za addresses with proper formatting
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.(com|ac\.za)$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email.Trim());
        }

        //Verify password
        public bool CheckPasswordMatch(string password1, string password2)
        {
            return password1.Equals(password2);
        }

        //Verifying cellphone number
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression for a 10-digit US phone number
            string pattern = @"^\d{10}$";

            // Check if the phone number matches the pattern
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public bool IsValidIDNumber(string idNo)
        {
            string pattern = @"^\d+$";

            if (!Regex.IsMatch(idNo, pattern))
            {
                return false;
            }

            if (idNo.Length < 9)
            {
                return false;
            }
            return true;
        }

        public bool isMoney(string rate)
        {
            string pattern = @"^\d+$";

            if (!Regex.IsMatch(rate, pattern))
            {
                return false;
            }

            return true;
        }

        public bool isNumber(string rate)
        {
            string pattern = @"^\d+$";

            if (!Regex.IsMatch(rate, pattern))
            {
                return false;
            }

            return true;
        }
        public bool IsValidCountryName(string country)
        {
            string pattern = @"^[A-Za-z]+(?:[\s-][A-Za-z]+)*$";
            return !string.IsNullOrWhiteSpace(country) && Regex.IsMatch(country.Trim(), pattern);
        }
        public bool IsValidName(string name)
        {
            // Regular expression to match only letters (no symbols or numbers)
            string pattern = @"^[A-Za-z]+(?:[\s-][A-Za-z]+)*$";
            return !string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name.Trim(), pattern);
        }
        public bool IsStrongPassword(string password)
        {
            if (password.Contains(" "))
            {
                return false;
            }
            // Check if password length is at least 8 characters
            if (password.Length < 8)
            {
                return false;
            }

            // Check if password contains at least one uppercase letter
            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            // Check if password contains at least one lowercase letter
            if (!password.Any(char.IsLower))
            {
                return false;
            }

            // Check if password contains at least one digit
            if (!password.Any(char.IsDigit))
            {
                return false;
            }

            // Check if password contains at least one special character
            string specialChars = @"!@#$%^&*()-_=+[]{}|;:'\\\"",.<>?";
            if (!password.Any(c => specialChars.Contains(c)))
            {
                return false;
            }
            //string pattern = @"[!@#$%^&*()]";
            //return Regex.IsMatch(password, pattern);
            // Check if password does not contain sequences of characters
            if (Regex.IsMatch(password, @"(.)\1{2,}"))
            {
                return false;
            }

            return true;
        }
    }

    

}
