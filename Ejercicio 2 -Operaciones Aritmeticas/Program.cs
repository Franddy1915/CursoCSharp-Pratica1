using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2__Operaciones_Aritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            float suma, resta, division, multiplicacion;
            float x, y;
           
            Console.WriteLine("Ingrese su primer digito");
            x= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su Segundo Digito digito");
            y= Convert.ToInt32(Console.ReadLine());
            suma = x + y;
            Console.WriteLine("El resultado de la suma es: " + suma);
          
            multiplicacion = x * y;
            Console.WriteLine("El resultado de la multiplicar es: " + multiplicacion);
            
            resta = x - y;
            Console.WriteLine("El resultado de la resta es: " + resta);
            
            division = x / y;
            Console.WriteLine("El resultado de la division es: " + division);
            Console.ReadKey();




        }
    }
}
