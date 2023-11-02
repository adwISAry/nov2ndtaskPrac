using november2nd.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace november2nd.Validators
{
    static class UserValidotar
    {
        public static void ValidatePhoneFormat(string phoneNumber)
        {
            string pattern = @"^\+994(?:55|50|77|70|51)\d{7}$";

            if (!Regex.IsMatch(phoneNumber, pattern))
            {                                                                                                                                 
                throw new InvalidPhoneFormat("Invalid phone number format");
            }
        }
        public static void ValidatePassword(string password)
        {
           string passwordPattern = @"^(?=.*[A-Z])(?=.*\d).{8,}$";

            if (!Regex.IsMatch(password, passwordPattern))
            {
                throw new InvalidPasswordException("Password should have at least 1 Uppercase letter, 1 digit and should have at least 8 characters");
            }
        }
    }
}
