using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese 3 Letras: ");
            string Letras = Console.ReadLine();
            Console.WriteLine (Letras[2]);
            Console.WriteLine(Letras[1]);
            Console.WriteLine(Letras[0]);
            Console.ReadKey();
        }
    }
}
