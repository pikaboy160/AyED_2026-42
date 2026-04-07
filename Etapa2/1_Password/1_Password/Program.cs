using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca Su Contraseña: ");
            string contraseña = "pikaboy";
            string usuario = Console.ReadLine();
            string usu = usuario.ToLower();
            if (contraseña == usu)
            {
                Console.WriteLine("Su Contraseña Es Correcta: ");
            }
            else
            {
                Console.WriteLine("Su Contraseña Es Incorrecta: ");
            }
            Console.ReadKey();
        }
    }
}
