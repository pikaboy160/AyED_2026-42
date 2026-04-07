using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Su Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Cuanto Gana Mensualmente");
            int sueldo = int.Parse(Console.ReadLine());
            if (edad > 19 && sueldo <= 100000 || edad < 19 && sueldo == 0 || edad == 19 && sueldo <= 50000)
            {
                Console.WriteLine("Su beca fue admitida");
            }
             else
            {
                Console.WriteLine("su beca fue rachazada");
            }
            Console.ReadKey();
        }
    }
}
