using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MiSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Un Numero:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Otro Numero:");
            int b = int.Parse(Console.ReadLine());
            int Resultado = a + b;
            Console.WriteLine("Su Resultado Es:" + Resultado);
            Console.ReadKey();
        }
    }
}
