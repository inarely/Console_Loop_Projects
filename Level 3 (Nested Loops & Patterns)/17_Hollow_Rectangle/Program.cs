using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Hollow_Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter width (>=2): ");
                int width = int.Parse(Console.ReadLine());

                Console.Write("Enter height (>=2): ");
                int height = int.Parse(Console.ReadLine());

                Console.Write("Enter a character: ");
                char a = Convert.ToChar(Console.ReadLine());

                if (width >= 2 && height >= 2)
                {
                    for (int i = 1; i <= height; i++)
                    {                       
                        for(int j = 1; j <= width; j++)
                        {
                            if (i == 1 || i == height || j == 1 || j == width)
                            {
                                Console.Write(a);
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Your number(s) is out of range.");
                    Console.WriteLine("Try again. (Press any key to retry)");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
