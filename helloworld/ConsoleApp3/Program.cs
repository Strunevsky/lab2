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
             double a=2, b=3,c ;
            Console.WriteLine("Ввести А");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввести Б");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выполнить операцию +");
            Console.WriteLine("Выполнить операцию -");
            Console.WriteLine("Выполнить операцию *");
            Console.WriteLine("Выполнить операцию /");
            char rez = char.Parse(Console.ReadLine());
            if (rez == '+')
            {
                c = a + b;
                Console.WriteLine(c);

            }
           else if (rez == '-')
            {
                c = a - b;
                Console.WriteLine(c);
            }
            else if (rez == '*')
            {
                c = a * b;
                Console.WriteLine(c);
            }
            else if (rez == '/')
            {
                c = a / b;
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
