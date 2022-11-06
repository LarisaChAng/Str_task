using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Str_task
{
    struct LinUravn
    {//Решение линейного уравнения типа: k*x+b=0
        double k;
        double b;

        public LinUravn(double k, double b)
        {
            Console.WriteLine("Линейное уравнение вида: k*x+b=0");
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k==0)
                return "Решений нет - деление на ноль!";
            double x = -b / k;
            return $"Решение: x={x:0.00}";
        }
    }
}
