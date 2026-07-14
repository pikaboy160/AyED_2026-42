using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _9_MatrizRotada90
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
            int[,] matriz_rotada = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz_1[i, j] = random.Next(1, 10);
                    matriz_2[i, j] = random.Next(1, 10);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    suma_matrices[i, j] = matriz_1[i, j] + matriz_2[i, j];
                    Console.Write(suma_matrices[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz_rotada[j, n - 1 - i] = suma_matrices[i, j];
                }
            }

            Console.WriteLine("matriz rotada en 90°");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz_rotada[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}