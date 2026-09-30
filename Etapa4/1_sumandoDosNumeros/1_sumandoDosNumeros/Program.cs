using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_sumandoDosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
        int resultado = Sumando2Numeros();

        Console.WriteLine(resultado);
        Console.ReadKey();
    }

    static int Sumando2Numeros()
    {
        Console.Write("Ingrese el valor 1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor 2: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = num1 + num2;

        return resultado;
    }



}
}
