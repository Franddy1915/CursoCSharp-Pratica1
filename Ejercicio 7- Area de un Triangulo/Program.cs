using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7__Area_de_un_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b;
            double h;
            double area;

            Console.WriteLine("Ingrese la base");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            area = (b * h) / 2;
            Console.WriteLine("El resultado es: " + area);
            Console.ReadKey();
        }
    }
}
