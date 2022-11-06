using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Str_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты k и b:");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            LinUravn linUravn = new LinUravn(k,b);
            Console.WriteLine(linUravn.Root());
            Console.ReadKey();
        }
    }
}
