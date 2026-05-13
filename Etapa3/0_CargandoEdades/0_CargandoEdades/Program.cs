using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_CargandoEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[5];
            for (int i = 1; i <= edades.Length; i++)
            {
                Console.Write($"Ingrese su edad y la de 4 wachines mas {i}: ");
                edades[i - 1] = int.Parse(Console.ReadLine());
            }
            for (int y = 0; y <= edades.Length; y++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Edades del alumno { y + 1}: {edades[y]}");
            }
            Console.ReadKey();
        }
    }
}
