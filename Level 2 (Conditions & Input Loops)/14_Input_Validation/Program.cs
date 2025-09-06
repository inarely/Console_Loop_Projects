using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Input_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number between 1 and 10: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 1 && number <= 10)
                {                    
                    Console.WriteLine($"Number {number} is within the Range :)");
                    break;
                }
                else
                {
                    Console.WriteLine("This number is out of Range. (Try again.)");
                    Console.WriteLine("\"Press any key to retry\".");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
