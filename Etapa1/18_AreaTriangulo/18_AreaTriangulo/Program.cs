using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce La Base Del Triangulo: ");
            float Base = float.Parse(Console.ReadLine());
            Console.Write("Introduce La Altura Del Triangulo: ");
            float Altura = float.Parse(Console.ReadLine());
            float Resultado = Base * Altura;
            float Area = Resultado / 2;
            Console.WriteLine("el Area Del Triangulo Es: " + Area);
            Console.ReadKey();
        }
    }
}
