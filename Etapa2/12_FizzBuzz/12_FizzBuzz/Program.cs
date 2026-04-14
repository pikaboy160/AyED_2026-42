using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            while (contador <= 100)
            {
                if (contador % 3 == 0 && contador %5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                } 
                else if (contador % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (contador % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(contador);
                }
                contador = contador + 1;
                Console.ReadKey();    
            }
        }
    }
}
