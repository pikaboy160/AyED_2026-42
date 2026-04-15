using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el precio: ");
            int factura = int.Parse(Console.ReadLine());

            Console.Write("Ingrese pago: ");
            int pago = int.Parse(Console.ReadLine());

            int dinero = pago - factura;

            Console.WriteLine("El vuelto total es: $" + dinero );

            while (dinero != 0)
            {
                if (dinero > 10000)
                {
                    int billete_10000 = dinero / 10000;
                    Console.WriteLine(billete_10000 + " billetes de 10000 $");
                    dinero = dinero % 10000; 
                }
                else if (dinero > 2000)
                {
                    int billete_2000 = dinero / 2000;
                    Console.WriteLine(billete_2000 + " billetes de 2000 $");
                    dinero = dinero % 2000;
                }
                else if (dinero > 1000)
                {
                    int billete_1000 = dinero / 1000;
                    Console.WriteLine(billete_1000 + " billetes de 1000 $");
                    dinero = dinero % 1000;
                }
                else if (dinero > 500)
                {
                    int billete_500 = dinero / 500;
                    Console.WriteLine(billete_500 + " billetes de 500 $");
                    dinero = dinero % 500;
                }
                else if (dinero > 200)
                {
                    int billete_200 = dinero / 200;
                    Console.WriteLine(billete_200 + " billetes de 200 $");
                    dinero = dinero % 200;
                }
                else if (dinero > 100)
                {
                    int billete_100 = dinero / 100;
                    Console.WriteLine(billete_100 + " billetes de 100 $");
                    dinero = dinero % 100;
                }
                else if (dinero > 50)
                {
                    int billete_50 = dinero / 50;
                    Console.WriteLine(billete_50 + " billetes de 50 $");
                    dinero = dinero % 50;
                }
                else if (dinero > 20)
                {
                    int billete_20 = dinero / 20;
                    Console.WriteLine(billete_20 + " billetes de 20 $");
                    dinero = dinero % 20;
                }
                else if (dinero > 10)
                {
                    int billete_10 = dinero / 10;
                    Console.WriteLine(billete_10 + " billetes de 10 $");
                    dinero = dinero % 10;
                }
                else if (dinero > 1)
                {
                    int cant10 = dinero / 10;
                    Console.WriteLine(cant10 + " billetes de 10 $");
                    dinero = dinero % 1;
                }              
            }
            Console.ReadKey();
        }
    }
}
