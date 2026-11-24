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
            for (int i = 0; i < edades.Length; i++)
            {
              Console.Write($"Ingrese edad {i + 1} de {edades.Length}: ");
              edades[i] = int.Parse(Console.ReadLine());
            }
            for (int y = 0; y < edades.Length; y++)
            {
              Console.WriteLine();
              Console.WriteLine($"Edad del alumno {y + 1}: {edades[y]}");
            }
            Console.ReadKey();
        }
    }
}