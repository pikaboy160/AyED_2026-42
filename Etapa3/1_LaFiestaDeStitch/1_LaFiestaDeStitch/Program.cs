using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de invitados: ");
            int invitados = int.Parse(Console.ReadLine());

            int[] comida = new int[invitados];

            for (int i = 0; i < comida.Length; i++)
            {
                Console.Write($"Ingrese la cantidad de comida para los invitados {i + 1} (entre 1 y 100 no me seas wachin): ");
                int valor = int.Parse(Console.ReadLine());           
                comida[i] = valor;
            }

            int sumaComida = 0;
            for (int i = 0; i < comida.Length; i++)
            {
                sumaComida = sumaComida + comida[i];
            }

            float promedio = (float)sumaComida / comida.Length;

            Console.WriteLine($"El total de invitados fue: {comida.Length} ");
            Console.WriteLine($"El promedio de comida es: {promedio}");

            Console.ReadKey();
        }
    }
}
