using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una de las 3 opciones");
            int opcion = 0;
                Console.WriteLine("opcion 1");
                Console.WriteLine("opcion 2");
                Console.WriteLine("opcion 3");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(" haz seleccionado la opcion 1 felicidades");
                        break;
                    case 2:
                        Console.WriteLine(" haz seleccionado la opcion 2 felicidades");
                        break;
                    case 3:
                        Console.WriteLine(" haz seleccionado la opcion 3 felicidades");
                        break;
                    default:
                        Console.WriteLine("Sos wachin");
                        break;

            }

            Console.ReadKey();
        }



    }
}
