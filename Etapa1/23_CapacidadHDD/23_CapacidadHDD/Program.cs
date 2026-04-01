using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca la cantidad de cilindros en el disco duro: ");
            float cantidad_cilindro = float.Parse(Console.ReadLine());
            Console.Write("Introduzca la cantidad de sectores en el disco duro: ");
            float cantidad_sectores = float.Parse(Console.ReadLine());
            Console.Write("Introduzca la cantidad de pistas en el disco duro: ");
            float cantidad_pistas = float.Parse(Console.ReadLine());
            float bytes = cantidad_cilindro * cantidad_pistas * cantidad_sectores * 512;
            float kilobytes = bytes / 1024;
            float megabytes = kilobytes / 1024;
            float gigabytes = megabytes / 1024;
            Console.WriteLine("Su Disco duro tiene " + kilobytes + "KB");
            Console.WriteLine("Su Disco duro tiene " + megabytes + "MB");
            Console.WriteLine("Su Disco duro tiene " + gigabytes + "GB");
            Console.ReadKey();
        }
    }
}
