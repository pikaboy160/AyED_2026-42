using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SuEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Su Edad:");
            int Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Su Edad Es:" + Edad);
            Console.ReadKey();
        }
    }
}
