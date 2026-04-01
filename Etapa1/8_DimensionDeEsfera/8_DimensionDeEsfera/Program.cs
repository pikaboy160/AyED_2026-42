using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Un Radio:");
            double Radio = double.Parse(Console.ReadLine());
            double Radio_2 = Radio * Radio;
            double PI = 3.14;
            double volumen = 4 / 3 * PI * Radio * Radio * Radio  ;
            double Superficie = 4 / 3 * PI * Radio_2;
            Console.WriteLine("Su Volumen Es:" + volumen + " Y Su Superficie Es:" + Superficie);
            Console.ReadKey();
        }
    }
}

