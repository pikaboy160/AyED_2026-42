using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila = 0;
            int col = 0;
            Console.Write("ingrese los datos de la columna:");
            col = int.Parse(Console.ReadLine());
            Console.Write("ingrese lso datos de la fila:");
            fila = int.Parse(Console.ReadLine());

            int[,] matriz = new int[fila, col];
            for (int i = 0; i < fila; i++)
            {
            for ( int j = 0; j < col; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
