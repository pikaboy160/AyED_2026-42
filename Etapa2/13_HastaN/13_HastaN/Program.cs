using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero limite: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = contador = 1;
            while (contador <= numero)
            {
                if (contador % 2 => 0)
                {
                    Console.WriteLine(contador);
                }
                contador = contador + 1;
            }
            Console.ReadKey();
        }
    }
}
