using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4__Convertor_Grado_Celcius_a_Farenhait
{
    class Program
    {
        static void Main(string[] args)
        {
            float f;
            float resultado;
            string hola = " Grados Celcius";
            Console.WriteLine("Ingrese el valor Grado Farenhait ");
            f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Presicione una tecla para continuar");
            Console.ReadKey();
            resultado = (f - 32) * 5 / 9;
            Console.WriteLine("Esto equivale a: " + resultado + hola);
            Console.ReadKey();
        }
    }
}
