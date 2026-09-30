using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_nivel_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
            int[,] g =
            {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
            bool ok = Level3.CountAdjacent(g, 1, 1) == 4
                   && Level3.CountAdjacent(g, 0, 0) == 2;
            Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
            Console.ReadKey();
        }
    }

    static class Level3
    {
        public static int CountAdjacent(int[,] matriz, int fila, int columna)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            int contador = 0;

            if (fila - 1 >= 0 && matriz[fila - 1, columna] == 1)
            {
                contador++;
            }

            if (fila + 1 < filas && matriz[fila + 1, columna] == 1)
            {
                contador++;
            }

            if (columna - 1 >= 0 && matriz[fila, columna - 1] == 1)
            {
                contador++;
            }

            if (columna + 1 < columnas && matriz[fila, columna + 1] == 1)
            {
                contador++;
            }

            return contador;
        }
    }
}