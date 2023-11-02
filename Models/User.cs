using november2nd.Utils;
using november2nd.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace november2nd.Models
{
    public class User
    {
        private string _name; 
        private int _age;
        private string _password;
        private string _phone;
        public string Name {
            get => _name;
            set
            {
                if (value.Length > 2 &&  value.Length < 30)
                { 
                _name = value;
                }
                else
                {
                throw new InvalidNameExpections("Name should be more than 2  and less than 30 characters");
                }
            }
        }
        public int Age { get => _age;
            set 
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new InvalidAgeException("Age must be real");
                }
            } 
        }
        public string Password { get => _password;
            set { UserValidotar.ValidatePassword(value); }
        }
        public string PhoneNumber { get => _phone;
            set{ UserValidotar.ValidatePhoneFormat(value); } 
        }
    }
}
