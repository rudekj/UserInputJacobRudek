using System;

namespace UserInputJacobRudek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi this is Jacob Rudek. Please enter your email address to join the mailing list." +
                "Type your email address below and hit enter");

            string useremail;

            useremail = Console.ReadLine();

            Console.WriteLine("You Entered:" + "  " + useremail);
        }
    }
}
