using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class UserValidation
    {
        public const string FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public bool CheckFirstName(string firstName)
        {
            Regex regex = new Regex(FIRST_NAME);
            return regex.IsMatch(firstName);
        }
    }
}
