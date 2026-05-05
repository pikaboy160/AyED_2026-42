using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los numeros impares son: ");
            int contador1 = 0;
            while (contador1 <= 100)
            {
                if (contador1 % 2 != 0)
                {
                    Console.Write(contador1 + " ");
                }
                contador1 += 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Los numeros pares son: ");
            int contador2 = 0;
            while (contador2 <= 100)
            {
                if (contador2 % 2 == 0)
                {
                    Console.Write(contador2 + " ");
                }
                contador2 += 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Los numeros del 0 al 100 son: ");
            int contador3 = 0;
            while (contador3 <= 100)
            {
                Console.Write(contador3 + " ");
                contador3 += 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Los numeros del 100 al 0 son: ");
            int contador4 = 100;
            while (contador4 >= 0)
            {
                Console.Write(contador4 + " ");
                contador4 -= 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Los multiplos de 3 son: ");
            int contador5 = 0;
            while (contador5 <= 100)
            {
                if (contador5 % 3 == 0)
                {
                    Console.Write(contador5 + " ");
                }
                contador5 += 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Los multiplos de 3 y de 2 son: ");
            int contador6 = 0;
            while (contador6 <= 100)
            {
                if (contador6 % 3 == 0 && contador6 % 2 == 0)
                {
                    Console.Write(contador6 + " ");
                }
                contador6 += 1;
            }
            Console.ReadKey();
        }
    }
}
