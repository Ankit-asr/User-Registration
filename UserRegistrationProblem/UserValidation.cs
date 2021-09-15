using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserValidation
    {
        public const string LAST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public bool CheckLastName(string lastName)
        {
            Regex regex = new Regex(LAST_NAME);
            return regex.IsMatch(lastName);
        }
    }
}
