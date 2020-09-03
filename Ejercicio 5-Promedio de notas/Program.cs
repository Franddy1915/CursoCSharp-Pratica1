using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_Promedio_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            double promedio;
            Console.WriteLine("Ingrese su primera nota");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segunda nota");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese tercera nota");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            promedio = (n1 + n2 + n3) / 3;
            Console.WriteLine("Su promedio es igual a: " + promedio);
            Console.ReadKey();
        }
    }
}
