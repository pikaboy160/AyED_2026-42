using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_HolaNombre
{
    class Program
    {
        static void Saludar(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Saludar("Santiago");
        }
            }
}



