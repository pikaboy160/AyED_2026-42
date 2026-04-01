using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce La Cantidad De Minutos: ");
            int minutos = int.Parse(Console.ReadLine());
            int horas = minutos / 60;
            int minutos_Sobrantes = minutos % 60;
            Console.WriteLine("La Cantidad De: " + minutos + " En Horas Es : " + horas + "h con " + minutos_Sobrantes + "min");
            Console.ReadKey();
        }
    }
}
