using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserValidation
    {
<<<<<<< HEAD
        public const string PASSWORD = "^[a-z]{8,}$";
        public bool CheckPassword(string password)
        {
            Regex regex = new Regex(PASSWORD);
=======
        public const string PASSWORD = "^.*[a-zA-Z]+.{8,}$";
        public bool CheckPassword(string password)
        {
            Regex regex = new Regex(password);
>>>>>>> UC6-PasswordValidationRule2
            return regex.IsMatch(password);
        }
    }
}
