using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca Un Presupuesto Anual Para Un Hospital: ");
            float Presupuesto = float.Parse(Console.ReadLine());
            float Ginecologia = Presupuesto * 40 / 100;
            float Trauma = Presupuesto * 30 / 100;
            Console.WriteLine("El Presupuesto Para Ginecologia Es : " + Ginecologia + "$");
            Console.WriteLine("El Presupuesto Para Traumatologia Es : " + Trauma + "$");
            Console.WriteLine("El Presupuesto Para Pediatria Es : " + Trauma + "$");
            Console.ReadKey();
        }
    }
}
