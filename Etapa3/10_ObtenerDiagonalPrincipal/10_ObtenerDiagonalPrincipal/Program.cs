using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ObtenerDiagonalPrincipal
{
    using System;

        class Program
        {
            static void Main(string[] args)
            {
                Random random = new Random();
                Console.Write("Ingrese la cantidad de filas y columnas: ");
                int n = int.Parse(Console.ReadLine());

                int[,] matriz = new int[n, n];
                int[] diagonal = new int[n];

                Console.WriteLine("Matriz Generada");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matriz[i, j] = random.Next(1, 101); 
                        Console.Write(matriz[i, j]+ " ");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < n; i++)
                {
                    diagonal[i] = matriz[i, i];
                }

                Console.WriteLine("Diagonal Principal:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(diagonal[i] + " ");
                }
                Console.WriteLine();

                Console.ReadKey();
            }
        }
    }
