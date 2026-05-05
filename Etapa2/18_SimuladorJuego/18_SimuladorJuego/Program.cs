using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            int vida = 10;
            int hambre = 10;
            int dias_sobrevividos = 1;
            int comida_cruda = 0;
            int comida_cocida = 0;
            bool tiene_refugio = false;
            bool tiene_fogata = false;
            bool tiene_materiales = false;
            bool ojo_turco = false;

            Random random = new Random();
            bool juego_funcar = true;

            Console.WriteLine("Bienvenido al trabajo que no tengo ni idea de como hacer");

            while (juego_funcar && vida > 0 && dias_sobrevividos < 1000)
            {
                Console.WriteLine("dia: " + (dias_sobrevividos) + " Vida: " + (vida) + " Hambre: " + (hambre));
                Console.WriteLine("Comida Cruda: " + (comida_cruda) + " Comida Cocida: " + (comida_cocida));
                Console.WriteLine("Refugio: " + (tiene_refugio ? "Sí" : "No") + " Fogata: " + (tiene_fogata ? "SI" : "No"));

                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Explorar la isla");
                Console.WriteLine("3. Construir refugio");
                Console.WriteLine("4. Encender fogata");
                Console.WriteLine("5. Cocinar comida");
                Console.WriteLine("6. Comer comida cocida");
                Console.WriteLine("7. Descansar");
                Console.WriteLine("8. Salir");
                Console.Write("Selecciona una opcion: ");

                string opcion = Console.ReadLine();
                bool avanza_el_dia = false;

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("te haz puesto a buscar comida...");
                        Console.WriteLine(" ");
                        vida = vida - 1;
                        int chances_comida = random.Next(1, 101);
                        if ( ojo_turco == true)
                        {

                            if (chances_comida <= 80)
                            {
                                comida_cruda = comida_cruda + 2;
                                Console.WriteLine("Haz encontrado 2 de comida cruda");
                                Console.WriteLine(" ");
                            }
                        }
                        else if (chances_comida <= 60)
                        {
                            comida_cruda = comida_cruda + 2;
                            Console.WriteLine("Haz encontrado 2 de comida cruda");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine("No haz encontrado nada de comida");
                            Console.WriteLine(" ");
                        }
                        avanza_el_dia = true;
                        break;

                    case "2":
                        Console.Clear();                       
                        Console.WriteLine("Te pusiste a explorar la isla...");
                        Console.WriteLine(" ");
                        int encontrar_algo = random.Next(1, 101);
                        if (encontrar_algo <= 50)
                        {
                            tiene_materiales = true;
                            Console.WriteLine("Haz encontrado materiales");
                            Console.WriteLine(" ");
                        }
                        else if (encontrar_algo <= 80)
                        {
                            Console.WriteLine("No encontraste nada chavalongo");
                            Console.WriteLine(" ");
                        }

                        else if (encontrar_algo <= 20)
                        {
                            ojo_turco = true;
                            Console.WriteLine(" ");
                            Console.WriteLine("encontraste un ojo turco (Ahora sientes algo diferente)");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            vida = vida - 2;
                            Console.WriteLine("Sufriste un accidente (jaja alto wachin)");
                            Console.WriteLine(" ");
                        }
                        avanza_el_dia = true;
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine(" ");
                        if (tiene_refugio == false && tiene_materiales == true)
                        {
                            tiene_refugio = true;
                            Console.WriteLine("Construiste un refugio");
                            Console.WriteLine(" ");
                            avanza_el_dia = true;
                        }
                        else if (tiene_refugio == true)
                        {
                            Console.WriteLine("Ya tienes un refugio");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine("No tienes materiales pedazo de bobi (explora la isla para conseguirlos)");
                        }
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine(" ");
                        if (tiene_refugio == true && tiene_fogata == false)
                        {
                            tiene_fogata = true;
                            Console.WriteLine("Prendiste una fogata");
                            avanza_el_dia = true;
                        }
                        else
                        {
                            Console.WriteLine("No tienes refugio O ya tienes una fogata");
                        }
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine(" ");
                        if (comida_cruda >= 1 && tiene_fogata == true)
                        {
                            comida_cruda = comida_cruda - 1;
                            comida_cocida = comida_cocida + 1;
                            Console.WriteLine("cocinaste un cacho carne de manera correcta");
                        }
                        else
                        {
                            Console.WriteLine("No tiene comida cruda O una fogata");
                        }
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine(" ");
                        if (comida_cocida >= 1)
                        {
                            comida_cocida = comida_cocida - 1;
                            hambre = hambre + 4;
                            if (hambre > 10)
                            {
                                hambre = 10;
                            }
                            Console.WriteLine("Comiste piola");
                            avanza_el_dia = true;
                        }
                        else
                        {
                            Console.WriteLine("No tienes comida cocida.");
                        }
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine(" ");
                        if (tiene_refugio == true)
                        {
                            vida = vida + 3;
                            Console.WriteLine("Te pusiste a dormir y recuperaste 3 de vida");
                        }
                        else
                        {
                            vida = vida + 1;
                            Console.WriteLine("Dormiste sin un refugio recuperaste 1 de vida");
                        }
                        if (vida > 10) { vida = 10; }
                        avanza_el_dia = true;
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine(" ");
                        juego_funcar = false;
                        Console.WriteLine("Cerrando el juego presione cualquier tecla para terminar");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine("Esa opcion no existe pedazo de wachin");
                        break;
                }
                if (avanza_el_dia == true)
                {
                    dias_sobrevividos = dias_sobrevividos + 1;
                    hambre = hambre - 2;

                    if (hambre < 0)
                    {
                        hambre = 0;
                        vida = vida - 2;
                        Console.WriteLine(" ");
                        Console.WriteLine("Tienes mucha hambre haz perdido 2 de vida");
                    }
                }
            }
            if (vida <= 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("La quedaste en la isla loco " + "Sobreviviste " + dias_sobrevividos + " Dias");
            }
            else if (dias_sobrevividos > 1000)               
            {
                Console.WriteLine(" ");
                Console.WriteLine("sobreviviste a la isla ostia");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para cerrar el juego");
            Console.ReadKey();

        }
    }

}




