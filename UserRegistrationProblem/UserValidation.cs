using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserValidation
    {
        public const string PHONE_NUMBER = "^[91]{2}\\s[0-9]{10}$";
        public bool CheckPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(PHONE_NUMBER);
            return regex.IsMatch(phoneNumber);
        }
    }
}
