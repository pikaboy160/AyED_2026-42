using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_SimuladorBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int partidas_ganadas = 0;
            int partidas_empatadas = 0;
            int partidas_perdidas = 0;
            int total_cartas_jugador = 0;
            int total_cartas_crupier = 0;

            bool programa_funcar = true;

            while (programa_funcar)
            {
                int puntaje_jugador = 0;
                int puntaje_crupier = 0;
                bool juego_funcar = true;

                while(juego_funcar)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("======= CASINO ZEUS =======");
                    Console.WriteLine(" ");
                    Console.WriteLine("Puntaje Del jugador: " + puntaje_jugador);
                    Console.WriteLine("Puntaje Del jugador: oculto ");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. Pedir Carta");
                    Console.WriteLine("2. Plantarse");
                    Console.WriteLine("3. Ver Reglas Del Juego y Estadisticas");
                    Console.WriteLine("4. Dejar De Jugar");
                    Console.WriteLine(" ");
                    Console.Write("Elija una opcion: ");
                    Console.WriteLine(" ");

                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            int carta = random.Next(1, 12);
                            puntaje_jugador = puntaje_jugador + carta;
                            total_cartas_jugador++;

                            Console.WriteLine("La carta que te salio es un: " + carta);
                            Console.WriteLine(" ");
                            Console.WriteLine("tu puntaje es: " + puntaje_jugador);

                            if (puntaje_jugador > 21)
                            {
                                partidas_perdidas++;
                                Console.WriteLine(" ");
                                Console.WriteLine("Perdiste la ronda brotheeeeeeeer");
                                juego_funcar = false;
                            }
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("turno del Crupier");

                            while (puntaje_crupier <= 17)
                            {
                                int carta_crupier = random.Next(1, 12);
                                puntaje_crupier = puntaje_crupier + carta_crupier;
                                total_cartas_crupier++;
                                Console.WriteLine(" ");
                                Console.WriteLine("el puntaje del crupier es: " + puntaje_crupier + " Y su cantidad de cartas agarradas son " + total_cartas_crupier);
                                Console.WriteLine(" ");
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Resultados: ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Puntaje Jugador: " + puntaje_jugador + " | Puntaje Crupier: " + puntaje_crupier);
                            if (puntaje_crupier > 21)
                            {
                                Console.WriteLine("El crupier se paso del limite de puntaje");
                                Console.WriteLine(" ");
                                partidas_ganadas++;
                            }
                            else if (puntaje_jugador > puntaje_crupier)
                            {
                                Console.WriteLine("Ganaste por puntaje");
                                Console.WriteLine(" ");
                                partidas_ganadas++;
                            }
                            else if (puntaje_jugador < puntaje_crupier)
                            {
                                Console.WriteLine("Perdiste por puntaje (jaja wachin)");
                                Console.WriteLine(" ");
                                partidas_perdidas++;
                            }
                            else
                            {
                                Console.WriteLine("Empataron (re wachines ambos)");
                                Console.WriteLine(" ");
                                partidas_empatadas++;
                            }
                            juego_funcar = false;
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Las reglas para jugar son las siguientes: ");
                            Console.WriteLine(" ");
                            Console.WriteLine("El objetivo es acercarse lo más posible a 21 puntos sin pasarse");
                            Console.WriteLine(" ");
                            Console.WriteLine("Cada carta suma puntos al puntaje total del jugador o del crupier");
                            Console.WriteLine(" ");
                            Console.WriteLine("Si el jugador supera los 21 puntos, pierde la partida automáticamente");
                            Console.WriteLine(" ");
                            Console.WriteLine("Si el jugador decide plantarse, deja de pedir cartas y comienza el turno del crupier");
                            Console.WriteLine(" ");
                            Console.WriteLine("El crupier debe pedir cartas mientras tenga menos de 17 puntos");
                            Console.WriteLine(" ");
                            Console.WriteLine("Cuando el crupier llega a 17 puntos o más, se planta");
                            Console.WriteLine(" ");
                            Console.WriteLine("Mientras no se pasen de 21 Gana el que tenga el puntaje mas alto");
                            Console.WriteLine(" ");
                            Console.WriteLine("Si ambos terminan con el mismo puntaje, la partida queda empatada");
                            Console.WriteLine(" ");
                            Console.WriteLine("Aquí le dejamos sus estadisticas: ");
                            Console.WriteLine("Ganadas: " + partidas_ganadas);
                            Console.WriteLine("Perdidas: " + partidas_perdidas);
                            Console.WriteLine("Empatadas: " + partidas_empatadas);
                            Console.WriteLine("Total Cartas tuyas: " + total_cartas_jugador);
                            Console.WriteLine("Total Cartas crupier: " + total_cartas_crupier);
                            juego_funcar = false;
                            break;

                        case 4:
                            Console.WriteLine(" ");
                            juego_funcar = false;
                            programa_funcar = false;
                            Console.WriteLine(" ");
                            Console.WriteLine("saliendo del programa toque cualquier tecla para cerrar");
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Esa opcion no existe pedazo de wachin");
                            break;
                    }
                    if (juego_funcar == false && programa_funcar == true)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Presione cualquier tecla para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
             

            }
        }
    }
}




