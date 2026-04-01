using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Un Numero:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Ingrese Otro Numero:");
            float b = float.Parse(Console.ReadLine());
            float Resultado = a / b;
            Console.WriteLine("Su Resultado Es:" + Resultado);
            Console.ReadKey();
        }
    }
}
