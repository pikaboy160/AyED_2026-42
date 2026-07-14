using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CentroPokeRemedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] vidas_Pokemones = new int[6];
            int cantidad_Pokemones = 0;
            int opcion = 0;

            while (opcion != 13)
            {
                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine("======= Centro Poke-Remedio =======");
                Console.WriteLine(" ");
                Console.WriteLine("1. Registrar un nuevo pokemon");
                Console.WriteLine("2. Mostrar la vida de los pokemons");
                Console.WriteLine("3. Curar a un Pokemon");
                Console.WriteLine("4. Dañar a un pokemon");
                Console.WriteLine("5. Curar a todos los pokemons");
                Console.WriteLine("6. Mostrar pokemons debilitados");
                Console.WriteLine("7. mostrar el pokemon con mas vida");
                Console.WriteLine("8. mostrar el pokemon con menos vida");
                Console.WriteLine("9. calcular promedio de vida del equipo");
                Console.WriteLine("10. ordenar pokemons por vida de menor a mayor");
                Console.WriteLine("11. ordenar pokemons por vida de mayor a menor");
                Console.WriteLine("12. Simular ataque enemigo a todo el equipo");
                Console.WriteLine("13. Salir");
                Console.Write("Elija una opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        if (cantidad_Pokemones >= vidas_Pokemones.Length)
                        {
                            Console.WriteLine("no se puede mas de 6 pokemons wachin");
                        }
                        else
                        {
                            Console.WriteLine(" el pokemon debe tener una vida entre 1 y 100");
                            int vida_ingresada = int.Parse(Console.ReadLine());

                            if (vida_ingresada < 0 || vida_ingresada > 100)
                            {
                                Console.WriteLine("la cantidad de vida tiene que ser entre 1 y 100 pedazo de Bigote");
                            }
                            else
                            {
                                vidas_Pokemones[cantidad_Pokemones] = vida_ingresada;
                                Console.WriteLine($"el pokemon a sido registrado en la posicion {cantidad_Pokemones}");
                                cantidad_Pokemones++;
                            }
                        }
                        break;

                    case 2:
                        if (cantidad_Pokemones == 0)
                        {
                            Console.WriteLine("No tenes pokemons registrados");
                        }
                        else
                        {
                            Console.Clear();
                            for (int i = 0; i < vidas_Pokemones.Length; i++)
                            {
                                if (i < cantidad_Pokemones)
                                {
                                    Console.WriteLine($"Pokémon {i + 1} - Vida: {vidas_Pokemones[i]}");
                                }
                            }
                        }
                        break;

                    case 3:
                       
                        if (cantidad_Pokemones == 0)
                        {
                            Console.WriteLine("No hay pokemones para curar");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"ingrese la posicion del pokemon que quiera curar ( 0 a {cantidad_Pokemones - 1}): ");
                            int despues_de_curar = int.Parse(Console.ReadLine());

                            if (despues_de_curar < 0 || despues_de_curar >= cantidad_Pokemones)
                            {
                                Console.WriteLine("esa posicion no existe paa selecciona una que exista de verdad que te la vamo a dar");
                            }
                            else
                            {
                                Console.WriteLine("Ingrese la cantidad de vida que quieras jugar: ");
                                int vida_curada = int.Parse(Console.ReadLine());
                                vidas_Pokemones[despues_de_curar] += vida_curada;

                                if (vidas_Pokemones[despues_de_curar] > 100)
                                {
                                    vidas_Pokemones[despues_de_curar] = 100;
                                }
                                Console.WriteLine($"el pokemon a sido curado su vida actual es de: {vidas_Pokemones[despues_de_curar]}");
                            }
                        }
                        break;

                    case 4:
                        Console.Clear();
                        if (cantidad_Pokemones == 0)
                        {
                            Console.WriteLine("No hay pokemones para para dañar");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"ponga la posicion del pokemon para dañar ( de 0 a {cantidad_Pokemones - 1}) ");
                            int despues_de_dañar = int.Parse(Console.ReadLine());

                            if (despues_de_dañar < 0 || despues_de_dañar >= cantidad_Pokemones)
                            {
                                Console.WriteLine("esa posicion es invalida ese pokemon no existe (wachin)");
                            }
                            else
                            {
                                Console.WriteLine("Pone cuanto daño queres hacer: ");
                                int puntos_daño = int.Parse(Console.ReadLine());

                                vidas_Pokemones[despues_de_dañar] -= puntos_daño;
                     
                                if (vidas_Pokemones[despues_de_dañar] < 0)
                                {
                                    vidas_Pokemones[despues_de_dañar] = 0;
                                }
                                Console.WriteLine("el pokemon aguanto el daño");
                                Console.WriteLine($"al pokemon le queda {vidas_Pokemones[despues_de_dañar]} puntos de vida restantes");
                            }
                        }
                        break;

                    case 5:
                        Console.Clear();
                        if (cantidad_Pokemones == 0)
                        {
                            Console.WriteLine("no hay pokemones registrados");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("ingrese la cantidad que quieras curar a todos los pokemones");
                            int curacion_general = int.Parse(Console.ReadLine());

                            for (int i = 0; i < cantidad_Pokemones; i++)
                            {
                                vidas_Pokemones[i] += curacion_general;
                                if (vidas_Pokemones[i] > 100)
                                {
                                    vidas_Pokemones[i] = 100;
                                }
                            }
                            Console.WriteLine($"todos los pokemones se han curado {curacion_general} puntos de vida");
                        }
                        break;

                    case 6:
                        Console.Clear();
                        if (cantidad_Pokemones == 0)
                        {
                            Console.WriteLine("no hay pokemones registrados");
                        }
                        else
                        {
                            Console.Clear();
                            int contador_Debilitados = 0;
                            Console.WriteLine("Pokemones debilitados:");

                            for (int i = 0; i < cantidad_Pokemones; i++)
                            {
                                if (vidas_Pokemones[i] == 0)
                                {
                                    Console.WriteLine($"Pokemon en posicion {i}");
                                    contador_Debilitados++;
                                }
                            }

                            if (contador_Debilitados == 0)
                            {
                                Console.WriteLine("No hay pokemones debilitados");
                            }
                            else
                            {
                                Console.WriteLine($"Cantidad total de debilitados: {contador_Debilitados}");
                            }
                        }
                        break;

                    case 7:
                        if (cantidad_Pokemones == 0)
                        {
                            Console.WriteLine("no hay pokemones registrados");
                        }
                        else
                        {
                            Console.Clear();
                            int mayor_Vida = vidas_Pokemones[0];
                            int pos_Mayor = 0;

                            for (int i = 1; i < cantidad_Pokemones; i++)
                            {
                                if (vidas_Pokemones[i] > mayor_Vida)
                                {
                                    mayor_Vida = vidas_Pokemones[i];
                                    pos_Mayor = i;
                                }
                            }
                            Console.WriteLine($"El pokémon con mayor vida esta en la posición {pos_Mayor} y tiene {mayor_Vida} puntos de vida");
                        }
                        break;

                    case 8:
                        if (cantidad_Pokemones == 0)
                        {
                            Console.WriteLine("no hay pokemones registrados");
                        }
                        else
                        {
                            Console.Clear();
                            int menor_Vida = vidas_Pokemones[0];
                            int pos_menor = 0;

                            for (int i = 1; i < cantidad_Pokemones; i++)
                            {
                                if (vidas_Pokemones[i] < menor_Vida)
                                {
                                    menor_Vida = vidas_Pokemones[i];
                                    pos_menor = i;
                                }
                            }
                            Console.WriteLine($"El pokémon con menor vida esta en la posición {pos_menor} y tiene {menor_Vida} puntos de vida");
                        }
                        break;

                    case 9:
                        if (cantidad_Pokemones == 0)
                        {
                            Console.WriteLine("no hay pokemones registrados");
                        }
                        else
                        {
                            Console.Clear();
                            int suma_vidas = 0;
                            for (int i = 0; i < cantidad_Pokemones; i++)
                            {
                                suma_vidas += vidas_Pokemones[i];
                            }
                            int promedio = (int)(suma_vidas) / cantidad_Pokemones;
                            Console.WriteLine($"el promedio de vida del equipo pokemon es {promedio}");

                            if (promedio > 70)
                            {
                                Console.WriteLine("El equipo esta en buen estado");
                            }
                            else if (promedio >= 31 && promedio <= 69) 
                            {
                                Console.WriteLine("El equipo necesita curacion");
                            }
                            else
                            {
                                Console.WriteLine("El equipo esta en peligro");
                            }
                        }
                        break;

                    case 10:
                        if (cantidad_Pokemones == 0)
                        {
                            Console.WriteLine("No hay pokemones para ordenar");
                        }
                        else
                        {
                            Console.Clear();
                            Array.Sort(vidas_Pokemones, 0, cantidad_Pokemones);

                            Console.WriteLine("pokemones ordenados de menor a mayor (teniendo en cuenta la vida): ");
                            for (int i = 0; i < cantidad_Pokemones; i++)
                            {
                                Console.WriteLine(vidas_Pokemones[i]);
                            }
                        }
                        break;

                    case 11:
                        if (cantidad_Pokemones == 0)
                        {
                            Console.WriteLine("No hay pokemones para ordenar");
                        }
                        else
                        {
                            Console.Clear();
                            Array.Sort(vidas_Pokemones, 0, cantidad_Pokemones);
                            Array.Reverse(vidas_Pokemones, 0, cantidad_Pokemones);

                            Console.WriteLine("Vidas ordenadas de mayor a menor(teniendo en cuenta la vida): ");
                            for (int i = 0; i < cantidad_Pokemones; i++)
                            {
                                Console.WriteLine(vidas_Pokemones[i]);
                            }
                        }
                        break;

                    case 12:
                        if (cantidad_Pokemones == 0)
                        {
                            Console.WriteLine("no hay pokemones para atacar");
                        }
                        else
                        {
                            Console.Clear();
                            int daño_random = random.Next(5, 26);
                            Console.WriteLine("un pokemon salvaje a atacado a tu equipo");
                            Console.WriteLine(" ");
                            Console.WriteLine($"recibiste un daño de {daño_random} a todo tu equipo");

                            for (int i = 0; i < vidas_Pokemones.Length; i++)
                            {
                                if (i < cantidad_Pokemones)
                                {
                                    vidas_Pokemones[i] -= daño_random;
                                    if (vidas_Pokemones[i] < 0)
                                    {
                                        vidas_Pokemones[i] = 0;
                                    }
                                }
                            }
                            Console.WriteLine("se actualizo la vida de los pokemones");
                        }
                        break;

                    case 13:
                        Console.Clear();
                        Console.WriteLine("gracias por jugar wachin");
                        return; 

                    default:
                        Console.Clear();
                        Console.WriteLine("Esa opcion no existe wachin");
                        break;
                }
                if (opcion != 13)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Presione cualquier tecla para volver al menu");
                    Console.ReadLine();
                }
            }
        }
    }
}