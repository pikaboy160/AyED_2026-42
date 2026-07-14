using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Ingrese la cantidad de filas y columnas: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz_1 = new int[n, n];
            int[,] matriz_2 = new int[n, n];
            int[,] suma_matrices = new int[n, n];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz_1[i, j] = random.Next(1, 101);
                    matriz_2[i, j] = random.Next(1, 101);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    suma_matrices[i, j] = matriz_1[i, j] + matriz_2[i, j];
                    Console.Write(suma_matrices[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
