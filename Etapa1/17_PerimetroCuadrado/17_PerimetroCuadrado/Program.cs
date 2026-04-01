using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce Un Lado Del Cuadrado: ");
            float Lado = float.Parse(Console.ReadLine());
            float perimetro = Lado * 4;
            float superficie = Lado * Lado;
            Console.WriteLine("el Perimetro del Cuadrado Es: " + perimetro + " Y La Superficie Es: " + superficie);
            Console.ReadKey();
        }
    }
}
