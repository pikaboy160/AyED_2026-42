using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Una Cantidad de grados celcius para el agua: ");
            int grados = int.Parse(Console.ReadLine());
            if (grados <= 0)  
            {
                Console.WriteLine("Su agua Congela");
            }
            if (grados >= 100)
            {
                Console.WriteLine("su agua hierve");
            }
            if (grados >= 1 && grados <= 99)
            {
                Console.WriteLine("Su agua esta en estado liquido");
            }
            Console.ReadKey();
        }
    }
}
