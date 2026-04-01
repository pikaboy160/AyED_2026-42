using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una temperatura en Celcius:");
            double C = double.Parse(Console.ReadLine());
            double F = C * 1.8 + 32;
            double K = C + 273.15;
            Console.WriteLine(C + "grados celcius en Kelvin es:" + K + " Y a Farenheit Es:" + F);
            Console.ReadKey();
        }
    }
}
