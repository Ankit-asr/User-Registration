using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber;
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("Enter a phone number");
            phoneNumber = Console.ReadLine();
            if (userValidation.CheckPhoneNumber(phoneNumber))
                Console.WriteLine(phoneNumber + " : is valid");
            else
                Console.WriteLine(phoneNumber + " : is not valid");
        }
    }
}