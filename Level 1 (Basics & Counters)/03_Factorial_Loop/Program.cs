using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Factorial_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int factorial = 1;            
            while (true)
            {
                Console.Write("Enter the number (Greater than 0, less than 13): ");
                n = int.Parse(Console.ReadLine());
                if(0 <= n && n <= 12)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Number shoud be greater than 0, less than 13");
                    Console.WriteLine("Press any key to retry");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            for(int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of \"{n}\" is: {factorial}");

        }
    }
}
