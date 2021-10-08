using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Prateek Bansal";
            int age = 30;
            bool isAlive = true;
            string contactNumber = "+64XXXXXXXXXX";

            Console.WriteLine($"{name}'s age is {age}.");
            Console.WriteLine($"is he alive? {isAlive}");
            Console.WriteLine($"His contact number is {contactNumber}");

            Console.ReadLine();
        }
    }
}