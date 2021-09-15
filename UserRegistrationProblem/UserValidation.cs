using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserValidation
    {
        public const string PASSWORD = "^.*[a-zA-Z]+.{8,}$";
        public bool CheckPassword(string password)
        {
            Regex regex = new Regex(password);
            return regex.IsMatch(password);
        }
    }
}
