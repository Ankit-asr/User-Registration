using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserValidation
    {
        public const string EMAIL = "^[a-z]{3,}([.][a-z]{3,})?[@][a-z]{2}[.][co]{2}([.][in]{2})?$";
        public bool CheckEmail(string email)
        {
            Regex regex = new Regex(EMAIL);
            return regex.IsMatch(email);
        }
    }
}
