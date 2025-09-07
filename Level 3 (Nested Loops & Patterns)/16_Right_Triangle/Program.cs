using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Right_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {               
                Console.Write("Enter the height of the right triangle (1 - 20): ");
                int number = int.Parse(Console.ReadLine());                
                 
                Console.Write("Enter the char to build the triangle: ");
                char a = Convert.ToChar(Console.ReadLine());

                if(1 <= number && number <= 20)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        for(int j = 1; j <= i; j++)
                        {
                            Console.Write(a + " ",3);
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"Number {number} is out of range.");
                    Console.WriteLine("Try again. (Press any key)");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
