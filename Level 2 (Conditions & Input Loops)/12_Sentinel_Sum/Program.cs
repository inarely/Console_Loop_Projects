using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Sentinel_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to add, (Enter 0 to see the sum).");
            int sum = 0;
            int count = 1;
            int number;

            do
            {
                Console.Write($"Number #{count}: ");
                number = int.Parse(Console.ReadLine());
                if (number != 0)
                {
                    sum += number;
                }
                count++;
            } while (number != 0);
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
