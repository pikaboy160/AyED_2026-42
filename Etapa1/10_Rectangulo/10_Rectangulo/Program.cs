using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el Ancho Del Rectangulo: ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Ingrese La Altura del Rectangulo: ");
            double Y = double.Parse(Console.ReadLine());
            double perimetro = 2 * X + 2 * Y;
            double area = X * Y;
            double raiz = X * X + Y * Y;
            double diagonal = Math.Sqrt(raiz);  
            Console.WriteLine("Su perimetro Es: " + perimetro );
            Console.WriteLine("Su area Es: " + area);
            Console.WriteLine("Su diagonal Es: " + diagonal);
            Console.ReadKey();
        }
    }
}
