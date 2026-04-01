using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Su Nombre: ");
            String Nombre = Console.ReadLine();
            Console.Write("Ingrese Su Edad: ");
            String Edad = Console.ReadLine();
            Console.Write("Ingrese Donde Vive: ");
            String Ciudad = Console.ReadLine();
            Console.WriteLine("Tu Nombre Es: " + Nombre + " Tienes " + Edad  + " Años " + "Y Vives En " + Ciudad);
            Console.ReadKey();
        }
    }
}
