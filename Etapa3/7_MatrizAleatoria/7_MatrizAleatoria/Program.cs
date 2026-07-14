using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("ingrese los datos de la columna:");
            int col = int.Parse(Console.ReadLine());
            Console.Write("ingrese los datos de la fila:");
            int fila = int.Parse(Console.ReadLine());
            int[,] matriz = new int[fila, col];
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}

        }
    }
}
