using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserValidation
    {
        public const string PASSWORD = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])([a-zA-Z0-9]+){8,}$";
        public bool CheckPassword(string password)
        {
            Regex regex = new Regex(PASSWORD);
            return regex.IsMatch(password);
        }
    }
}
