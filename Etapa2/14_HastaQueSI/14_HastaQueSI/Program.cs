using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Desea terminar el programa? ");
            string RTA = Console.ReadLine();
            while (RTA == "SI")
            {
               Console.Write("¿Desea terminar el programa? ");
                RTA = Console.ReadLine();
            }

        }
    }
}
