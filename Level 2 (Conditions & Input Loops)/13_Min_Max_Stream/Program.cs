using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Min_Max_Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers to input: ");
            int amountOfNumbers = int.Parse(Console.ReadLine());
            int number, maxValue = 0,  minValue = 0;
            //int count = 1;
            for (int i = 1; i <= amountOfNumbers; i++)
            {
                Console.Write($"Enter Number #{i}: ");
                number = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    maxValue = number;
                    minValue = number;
                }
                else 
                {
                    if (number > maxValue)
                        maxValue = number;
                    
                    if(number < minValue)
                        minValue = number;
                }
            }
            Console.WriteLine($"Max Value: {maxValue}");
            Console.WriteLine($"Min Value: {minValue}");
        }
    }
}
