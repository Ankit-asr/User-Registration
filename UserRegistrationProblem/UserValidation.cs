using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserValidation
    {
        public const string PASSWORD = "^[a-z]{8,}$";
        public bool CheckPassword(string password)
        {
            Regex regex = new Regex(PASSWORD);
            return regex.IsMatch(password);
        }
    }
}
