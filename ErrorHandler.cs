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

            string pattern = @"^[a-zA-Z0-9_.+-]+@(?:[a-zA-Z0-9-]+\.)+(com|co\.za|ac\.za)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
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
        public bool IsValidName(string name)
        {
            // Regular expression to match only letters (no symbols or numbers)
            string pattern = @"^[a-zA-Z]+$";

            // Check if the name matches the pattern
            return Regex.IsMatch(name, pattern);
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
