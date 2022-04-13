using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Include First number");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Include second number ");
            int number_2 = Convert.ToInt32(Console.ReadLine());
            if (number_1 > number_2) {
                Console.WriteLine("First number is larger than second number");

            }
            else if (number_1 == number_2) {
                Console.WriteLine("First number is equal to second number");
            }
            else {
                Console.WriteLine("Second number is larger than first number"); 
            }
            
            
            
            
           


        }
    }
}
