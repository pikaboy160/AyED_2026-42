using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Un Numero: ");
            float numero = float.Parse(Console.ReadLine());
            float numero_Cuadrado = numero * numero;
            float numero_Cubico = numero * numero * numero;
            Console.WriteLine("el Cuadrado de: " + numero + " es " + numero_Cuadrado + " Y el Cubico Es: " + numero_Cubico);
            Console.ReadKey();
        }
    }
}
