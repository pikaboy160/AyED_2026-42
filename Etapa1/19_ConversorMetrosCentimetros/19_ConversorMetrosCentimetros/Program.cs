using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce La Cantidad De Metros: ");
            float Metros = float.Parse(Console.ReadLine());
            float Centimetros = Metros * 100;
            Console.WriteLine("La Cantidad De: " + Metros + " En Centimetros Es: " + Centimetros);
            Console.ReadKey();
        }
    }
}
