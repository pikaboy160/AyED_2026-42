using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AnioBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un año: ");
            int año = int.Parse(Console.ReadLine());
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {
                Console.WriteLine("el año ingresado es bisiesto");
            }
            else
            {
                Console.WriteLine("El año ingresado no es bisiesto");
            }
            Console.ReadKey();
        }
    }
}
