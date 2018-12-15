using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
                while (true)
                {
                    int a = 0, timep1 = 0, timep2 = 0, p1 = 0, p2 = 0, t = 0;
                    Console.Write("Введите кол-во страниц: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите время 1 принтера: ");
                    timep1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите время 2 принтера: ");
                    timep2 = Convert.ToInt32(Console.ReadLine());
                    while (a > 0)
                    {
                        t++;
                        p1++;
                        p2++;
                        if (p1 == timep1)
                        {
                            a--;
                            p1 = 0;
                        }
                        if (p2 == timep2)
                        {
                            a--;
                            p2 = 0;
                        }
                    }
                    Console.WriteLine(t);
                }
            }
        }
}