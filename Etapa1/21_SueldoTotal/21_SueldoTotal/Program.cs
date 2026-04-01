using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            int Horas = int.Parse(Console.ReadLine());
            Console.Write("Introduce La Cantidad De Dinero Por Hora: ");
            int Dinero = int.Parse(Console.ReadLine());
            int Sueldo_Total = Horas * Dinero;
            Console.WriteLine("El Sueldo Por las Horas Trabajadas Es De: " + Sueldo_Total);
        }
    }
}
