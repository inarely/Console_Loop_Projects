using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Digits_With_Sum_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter N (1 - 18): ");
                int number = int.Parse(Console.ReadLine());
                if (number >= 1 && number <= 18)
                {
                    for (int n = 10; n <= 99; n++)
                    {
                        int tens = n / 10;
                        int ones = n % 10;

                        if (tens + ones == number)
                        {
                            Console.Write(n + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("The number is out of range.");
                    Console.WriteLine("Press any key to retry.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
