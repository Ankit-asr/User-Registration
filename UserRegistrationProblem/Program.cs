using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("Enter Email ID:");
            email = Console.ReadLine();
            if (userValidation.CheckEmail(email))
            {
                Console.WriteLine(email + "is Valid");
            }
            else
                Console.WriteLine("Email not Valid");
        }
    }
}