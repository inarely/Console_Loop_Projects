using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Palindromes_In_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter A (start of range >= 1): ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter B (end of range <= 99.999): ");
                int b = int.Parse(Console.ReadLine());

                if (0 <= a && a < b && b <= 99999)
                {
                    for (int i = a; i <= b; i++)
                    {
                        int temp = i;
                        int reverse = 0;

                        while (temp > 0)
                        {
                            int digit = temp % 10;
                            reverse = reverse * 10 + digit;
                            temp /= 10;

                        }
                        if (reverse == i)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Number(s) is out of the range.");
                    Console.WriteLine("Press any key to retry.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
