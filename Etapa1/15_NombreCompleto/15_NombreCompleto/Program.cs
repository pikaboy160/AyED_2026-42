using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NombreCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Su Nombre: ");
            String Nombre = Console.ReadLine();
            Console.Write("Ingrese Su Apellido: ");
            String Apellido = Console.ReadLine();
            Console.WriteLine("Su Nombre Completo Es: " + Nombre + " " + Apellido);  
            Console.ReadKey();
        }
    }
}
