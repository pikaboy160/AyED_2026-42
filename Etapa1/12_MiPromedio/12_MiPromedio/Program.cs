using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Ingrese Un Numero: ");
           float numero1 = float.Parse(Console.ReadLine());
           Console.Write("Ingrese El Segundo Numero: ");
           float numero2 = float.Parse(Console.ReadLine());
           Console.Write("Ingrese El Tercer Numero: ");
           float numero3 = float.Parse(Console.ReadLine());
           float Suma_total = numero1 + numero2 + numero3;
           float Promedio = Suma_total / 3;
            Console.Write("Su Promedio  Es: " + Promedio);   
           Console.ReadKey();
        }
    }
}
