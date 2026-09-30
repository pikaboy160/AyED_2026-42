using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Calculando
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora();
            Console.ReadKey();
        }
        static void Calculadora()
        {
            bool bucle = true;
            while (bucle)
            {
                Console.WriteLine("elija una de las opciones de la calculadora");
                Console.WriteLine("");
                Console.WriteLine("1) sumar");
                Console.WriteLine("2) restar");
                Console.WriteLine("3) multiplicar");
                Console.WriteLine("4) dividir");
                Console.WriteLine("5) salir");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Ingrese un numero: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese un numero: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("la suma de los 2 numeros es: " + Sumar(n1, n2));
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Ingrese un numero: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese un numero: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("la suma de los 2 numeros es: " + restar(n1, n2));
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Ingrese un numero: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese un numero: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("la suma de los 2 numeros es: " + multiplicar(n1, n2));
                        break;

                    case 4:
                        Console.Clear();
                        Console.Write("Ingrese un numero: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese un numero: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("la suma de los 2 numeros es: " + dividir(n1, n2));
                        break;
                    case 5:
                        Console.Clear();
                        bucle = false;
                        break;
                    default:
                        {
                            Console.WriteLine("esa opción no existe");
                        }
                        break;
                }

            }


        }
        static int Sumar(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }
        static int restar(int n1, int n2)
        {
            int resultado = n1 - n2;
            return resultado;
        }
        static int multiplicar(int n1, int n2)
        {
            int resultado = n1 * n2;
            return resultado;
        }
        static int dividir(int n1, int n2)
        {
            int resultado = n1 / n2;
            return resultado;
        }
    }
}
