using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un angulo de un triangulo: ");
            int lado_1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el segundo de un triangulo: ");
            int lado_2 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el tercer de un triangulo: ");
            int lado_3 = int.Parse(Console.ReadLine());
            if (lado_1 + lado_2 > lado_3 &&lado_1 + lado_3 > lado_2 && lado_2 + lado_3 > lado_1)
            {
                Console.Write("Tienes un triangulo");
            }
                
                if (lado_1 == lado_2 && lado_1 == lado_3)
            {
                Console.Write(" equilatero");
            }
            if (lado_1 == lado_2 && lado_1 != lado_3)
            {
                Console.Write(" isosceles");
            }
            if (lado_1 != lado_2 && lado_1 != lado_3)
            {
                Console.Write(" octusangulo");
            }
            Console.ReadKey();

        }
    }
}
