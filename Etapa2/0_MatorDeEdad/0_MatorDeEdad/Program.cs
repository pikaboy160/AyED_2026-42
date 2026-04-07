using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_MatorDeEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Su Edad: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18) {
                Console.WriteLine("Eres Mayor de Edad");
            }
            else
            {
                Console.WriteLine("No Eres Mayor Edad");
            }
            Console.ReadKey();
        }
    }
}
