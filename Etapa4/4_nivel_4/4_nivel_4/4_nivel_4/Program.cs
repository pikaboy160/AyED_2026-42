using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_nivel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
                string msg = "ctOS";
                string enc = Level4.CaesarPlusOne(msg);
                bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
                Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
            }
        }

        static class Level4
        {
            public static string CaesarPlusOne(string s)
            {
                // TODO: implementar
                // Reglas: letras rotan (z→a, Z→A), mantener may/min; otros chars, igual.
                return string.Empty; // <- reemplazar por tu solución
            }
        }
    }
}
