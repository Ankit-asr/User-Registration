using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("Enter password");
            password = Console.ReadLine();
            if (userValidation.CheckPassword(password))
                Console.WriteLine(password + " : is valid");
            else
                Console.WriteLine(password + " : is not valid");
        }
    }
}