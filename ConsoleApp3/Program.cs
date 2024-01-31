using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HW(10);
        }

        static void HW(uint countSites)
        {
            bool[] sites = new bool[countSites];

            while (true)
            {
                int Input;
                Console.WriteLine("Enter 1 for exit");
                Input = Convert.ToInt32(Console.ReadLine());
                if (Input == 1) { break; }

                Console.WriteLine("Enter 1 for курящих");
                Console.WriteLine("Enter 2 for некурящих");

                Input = Convert.ToInt32(Console.ReadLine());

                if (Input == 1) 
                {
                    bool Checker = false;
                    for(int i = 0; i < Input / 2; i++)
                    {
                        if (sites[i] != true)
                        {
                            sites[i] = true;
                            Checker = true;
                            Console.WriteLine($"Пасажир посажин на место{i}");
                            break;
                        }
                    }
                    if (Checker == true)
                    {
                        continue;
                    }
                   Console.WriteLine($"no sites");

                }
                else if (Input == 2) 
                {
                    bool Checker = false;
                    for (int i = 9; i >= countSites / 2; i--)
                    {
                        if (sites[i] != true)
                        {
                            sites[i] = true;
                            Checker = true;
                            Console.WriteLine($"Пасажир посажин на место{i}");
                            break;
                        }
                    }
                    if (Checker == true)
                    {
                        continue;
                    }
                    Console.WriteLine($"no sites");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
