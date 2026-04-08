using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.Write("¿tienes un refugio? (SI/NO) ");
            bool refugio = Console.ReadLine().ToLower() == "si";
            Console.Write("¿tienes comida? (SI/NO) ");
            bool comida = Console.ReadLine().ToLower() == "si";
            Console.Write("¿tienes algo con que defenderte? (SI/NO) ");
            bool arma = Console.ReadLine().ToLower() == "si";
            Console.Write("¿tienes agua? (SI/NO) ");
            bool agua = Console.ReadLine().ToLower() == "si";
            Console.Write("¿tienes Medicinas? (SI/NO) ");
            bool medicina = Console.ReadLine().ToLower() == "si";
            Console.Write("¿tienes problema fisico? (SI/NO) ");
            bool fisico = Console.ReadLine().ToLower() == "si";

            if ( refugio && comida && arma && agua )
            {
                Console.WriteLine("Puedes sobrevivr al apocalipsis");
            }
            else
            {
                Console.WriteLine("No puedes sobrevivir al apocalipsis");
            }
            Console.ReadKey();
            
        }
    }
}
