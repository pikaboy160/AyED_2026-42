using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Sumando2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Ingrese un numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("la suma de los 2 numeros es: " + Sumar(n1,n2));
            Console.ReadKey();
        }
        static int Sumar(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }       
    }
}
