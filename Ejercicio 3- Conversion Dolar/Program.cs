using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3__Conversion_Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar;
            dolar = 58.80;
            double peso;
            double resultado;
            Console.WriteLine("Ingrese el monto en Dolar: ");
            peso = Convert.ToInt32(Console.ReadLine());
            resultado = peso * dolar;
            Console.WriteLine("Este es su valor en Pesos: " + resultado);
            Console.ReadKey();
        }
    }
}
