using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            UserValidation userValidation = new UserValidation();
<<<<<<< HEAD
            Console.WriteLine("Enter a password");
=======
            Console.WriteLine("Enter password");
>>>>>>> UC6-PasswordValidationRule2
            password = Console.ReadLine();
            if (userValidation.CheckPassword(password))
                Console.WriteLine(password + " : is valid");
            else
                Console.WriteLine(password + " : is not valid");
        }
    }
}