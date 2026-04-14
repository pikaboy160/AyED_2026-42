using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero y le mostraremos su cuenta regresiva: ");
            int cuenta_regresiva = int.Parse(Console.ReadLine());
            while (cuenta_regresiva >= 0)
            {
                Console.WriteLine(cuenta_regresiva);
                cuenta_regresiva = cuenta_regresiva - 1;
            }
            Console.ReadKey();
        }
    }
}
