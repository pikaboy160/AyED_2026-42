using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int alumnos = int.Parse(Console.ReadLine());

            string[,] matriz = new string[alumnos, 3];

            for (int i = 0; i < alumnos; i++)
            {
                Console.WriteLine($"Datos del Alumno N° {i + 1}");

                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Ingrese el nombre: ");
                        matriz[i, j] = Console.ReadLine();
                    }
                    else if (j == 1)
                    {
                        Console.Write("Ingrese la edad: ");
                        matriz[i, j] = Console.ReadLine(); 
                    }
                    else if (j == 2)
                    {
                        Console.Write("Ingrese la calificación: ");
                        matriz[i, j] = Console.ReadLine(); 
                    }
                }
            }
            for (int i = 0; i < alumnos; i++)
            {
                Console.WriteLine($"nombre del alumno : {matriz[i, 0]}");
                Console.WriteLine("");
               Console.WriteLine($"edad del alumno : {matriz[i, 1]}");
                Console.WriteLine("");
                Console.WriteLine($"calificacion del alumno : {matriz[i, 2]}");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}