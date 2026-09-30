using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Balatrito
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== MINI BALATRITRO CAUSA ===");
            Console.WriteLine();

            string[] mano = GenerarManoAleatoria();

            string tipo = TipoDeMano(mano);


            int basePts = PuntajeBase(mano);


            double mult = Multiplicador(tipo);


            double total = basePts * mult;

            bool jokerX2 = true;
            bool jokerMas10 = true;


            total = AplicarJokers(total, jokerX2, jokerMas10);


            MostrarResumen(mano, tipo, basePts, mult, total);

            Console.ReadKey();
        }


        static string[] GenerarManoAleatoria()
        {
            string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] palos = { "H", "D", "C", "S" };

            Random random = new Random();

            string[] mano = new string[5];

            for (int i = 0; i < 5; i++)
            {
                int posicionRango = random.Next(rangos.Length);
                int posicionPalo = random.Next(palos.Length);

                mano[i] = rangos[posicionRango] + palos[posicionPalo];
            }

            return mano;
        }

        static string TipoDeMano(string[] mano)
        {
            int[] repeticiones = new int[5];

            for (int i = 0; i < mano.Length; i++)
            {
                repeticiones[i] = 1;

                for (int j = 0; j < mano.Length; j++)
                {
                    if (i != j && mano[i][0] == mano[j][0])
                    {
                        repeticiones[i]++;
                    }
                }
            }

            bool hay4 = false;
            bool hay3 = false;
            int cantidadDePares = 0;

            for (int i = 0; i < repeticiones.Length; i++)
            {
                if (repeticiones[i] == 4)
                    hay4 = true;

                if (repeticiones[i] == 3)
                    hay3 = true;

                if (repeticiones[i] == 2)
                    cantidadDePares++;
            }

            if (hay4)
                return "Poker";

            if (hay3 && cantidadDePares == 2)
                return "Full";

            if (hay3)
                return "Trio";

            if (cantidadDePares > 0)
                return "Par";

            return "Nada";
        }

        static int PuntajeBase(string[] mano)
        {
            int total = 0;

            for (int i = 0; i < mano.Length; i++)
            {
                char rango = mano[i][0];

                switch (rango)
                {
                    case 'A':
                        total += 14;
                        break;

                    case 'K':
                        total += 13;
                        break;

                    case 'Q':
                        total += 12;
                        break;

                    case 'J':
                        total += 11;
                        break;

                    case 'T':
                        total += 10;
                        break;

                    default:
                        total += rango - '0';
                        break;
                }
            }

            return total;
        }

        static double Multiplicador(string tipo)
        {
            switch (tipo)
            {
                case "Par":
                    return 1.5;

                case "Trio":
                    return 2.5;

                case "Full":
                    return 3.5;

                case "Poker":
                    return 4.0;

                default:
                    return 1.0;
            }
        }

        static double AplicarJokers(double puntaje, bool x2, bool mas10)
        {
            if (x2)
                puntaje = puntaje * 2;

            if (mas10)
                puntaje = puntaje + 10;

            return puntaje;
        }

        static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
        {
            Console.Write("Mano: ");

            for (int i = 0; i < mano.Length; i++)
            {
                Console.Write("[" + mano[i] + "] ");
            }

            Console.WriteLine();
            Console.WriteLine("Tipo de mano: " + tipo);
            Console.WriteLine("Puntaje base: " + basePts);
            Console.WriteLine("Multiplicador: x" + mult);
            Console.WriteLine("Puntaje final: " + total);
        }
    }
}