using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDelNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca cuantas monedas doradas consiguio: ");
            int dorada = int.Parse(Console.ReadLine());
            Console.Write("Introduzca cuantas monedas plateada consiguio: ");
            int plateada = int.Parse(Console.ReadLine());
            int dorada_valor = dorada * 10;
            int plateada_valor = plateada * 2;
            int suma = plateada_valor + dorada_valor; 
            if(suma < 50)
            {
                Console.WriteLine("nivel insuficiente");
            }
            if (suma >= 50 && suma <= 99)
            {
                Console.WriteLine("nivel superado");
            }
            if (suma > 100)
            {
                Console.WriteLine("nivel Superado con bonus");
            }
            Console.ReadKey();
        }
    }
}
