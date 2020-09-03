using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6__Convertor_de_millas_a_KMs
{
    class Program
    {
        static void Main(string[] args)
        {
            double milla;
            milla = 1;
            double km;
            km = 1.60934;
            double resultado;
            string millas = ("Km");
            Console.WriteLine("Ingrese un valor");
            milla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            resultado = milla * km;
            Console.WriteLine("El resultado es: " + resultado + millas);
            Console.ReadKey();
        }
    }
}
