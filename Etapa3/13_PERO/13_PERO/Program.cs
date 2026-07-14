using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_PERO
{
    class Program
    {
        static void Main(string[] args)
        {
                Random rand = new Random();
                int[,] misiones = new int[30, 5];
                int cantidadMisiones = 0;
                int proximoId = 1;
                int opcion;
                do
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("         ==== MENU DEL P.E.R.O. ====");
                    Console.WriteLine("========================================");
                    Console.WriteLine("1. Registrar nueva misión");
                    Console.WriteLine("2. Ver todas las misiones");
                    Console.WriteLine("3. Cambiar estado de una misión");
                    Console.WriteLine("4. Listar misiones en curso");
                    Console.WriteLine("5. Misión con más objetos a extraer");
                    Console.WriteLine("6. Promedio de pegrilo por mapa");
                    Console.WriteLine("7. Filtrar por mapa");
                    Console.WriteLine("8. Salir");
                    Console.WriteLine("========================================");
                    Console.Write("Opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            if (cantidadMisiones >= 30)
                            {
                                Console.WriteLine("Demasiadas misiones pa");
                            }
                            else
                            {
                                Console.WriteLine("--- REGISTRAR NUEVA MISION ---");

                                int mapaElegido = 0;
                                bool mapaValido = false;
                                while (mapaValido == false)
                                {
                                    Console.Write("Ingrese numero de Mapa (1 = Hagwarts, 2 = La Casa del Viejo, 3 = El Laboratorio): ");
                                    mapaElegido = int.Parse(Console.ReadLine());

                                    if (mapaElegido >= 1 && mapaElegido <= 3)
                                    {
                                        mapaValido = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ese mapa no es de este juegazo Intente de nuevo");
                                    }
                                }
                                int peligroElegido = 0;
                                bool peligroValido = false;
                                while (peligroValido == false)
                                {
                                    Console.Write("Ingrese nivel de peligro (1 a 5): ");
                                    peligroElegido = int.Parse(Console.ReadLine());

                                    if (peligroElegido >= 1 && peligroElegido <= 5)
                                    {
                                        peligroValido = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Este nivel es demasiado PEGRILOSO... Intente de nuevo.");
                                    }
                                }

                                int objetosAleatorios = rand.Next(1, 71);
                                misiones[cantidadMisiones, 0] = proximoId;         
                                misiones[cantidadMisiones, 1] = mapaElegido;       
                                misiones[cantidadMisiones, 2] = objetosAleatorios; 
                                misiones[cantidadMisiones, 3] = peligroElegido;   
                                misiones[cantidadMisiones, 4] = 0; 

                                Console.WriteLine($"\n¡Misión registrada con éxito!");
                                Console.WriteLine($"ID Asignado: {proximoId} | Objetos a extraer: {objetosAleatorios}");
                                proximoId++;
                                cantidadMisiones++;
                            }
                            break;

                        case 2:
                            if (cantidadMisiones == 0)
                            {
                                Console.WriteLine("No hay misiones registradas todavia");
                            }
                            else
                            {
                                Console.WriteLine("--- TODAS LAS MISIONES ---");
                                for (int i = 0; i < cantidadMisiones; i++)
                                {
                                    string nombreMapa = "";
                                    if (misiones[i, 1] == 1) nombreMapa = "Hagwarts";
                                    if (misiones[i, 1] == 2) nombreMapa = "La Casa del Viejo";
                                    if (misiones[i, 1] == 3) nombreMapa = "El Laboratorio";

                                    string nombreEstado = "";
                                    if (misiones[i, 4] == 0) nombreEstado = "Pendiente";
                                    if (misiones[i, 4] == 1) nombreEstado = "En curso";
                                    if (misiones[i, 4] == 2) nombreEstado = "Finalizado";

                                    Console.WriteLine($"ID: {misiones[i, 0]} | Mapa: {nombreMapa} | Objetos: {misiones[i, 2]} | Peligro: {misiones[i, 3]}/5 | Estado: {nombreEstado}");
                                }
                            }
                            break;

                        case 3:
                            if (cantidadMisiones == 0)
                            {
                                Console.WriteLine("No hay misiones para modificar");
                            }
                            else
                            {
                                Console.WriteLine("\n--- CAMBIAR ESTADO ---");
                                Console.Write("Ingrese el ID de la misión a avanzar: ");
                                int idBuscado = int.Parse(Console.ReadLine());

                                bool encontrada = false;
                                for (int i = 0; i < cantidadMisiones; i++)
                                {
                                    if (misiones[i, 0] == idBuscado)
                                    {
                                        encontrada = true;

                                        if (misiones[i, 4] == 0)
                                        {
                                            misiones[i, 4] = 1;
                                            Console.WriteLine($"¡La misión ID {idBuscado} ahora está EN CURSO!");
                                        }
                                        else if (misiones[i, 4] == 1)
                                        {
                                            misiones[i, 4] = 2; 
                                            Console.WriteLine($"La misión ID {idBuscado} ahora está FINALIZADA");
                                        }
                                        else if (misiones[i, 4] == 2)
                                        {
                                            Console.WriteLine($"La misión ID {idBuscado} ya esta finalizada No puede avanzar mas");
                                        }
                                    }
                                }

                                if (!encontrada)
                                {
                                    Console.WriteLine("No se encontro ninguna misión con ese ID");
                                }
                            }
                            break;

                        case 4:
                            if (cantidadMisiones == 0)
                            {
                                Console.WriteLine("No hay misiones registradas.");
                            }
                            else
                            {
                                Console.WriteLine("--- MISIONES EN CURSO ---");
                                int contadorEnCurso = 0;

                                for (int i = 0; i < cantidadMisiones; i++)
                                {
                                    if (misiones[i, 4] == 1) 
                                    {
                                        string nombreMapa = "";
                                        if (misiones[i, 1] == 1) nombreMapa = "Hagwarts";
                                        if (misiones[i, 1] == 2) nombreMapa = "La Casa del Viejo";
                                        if (misiones[i, 1] == 3) nombreMapa = "El Laboratorio";

                                        Console.WriteLine($"ID: {misiones[i, 0]} | Mapa: {nombreMapa} | Objetos: {misiones[i, 2]} | Peligro: {misiones[i, 3]}");
                                        contadorEnCurso++;
                                    }
                                }

                                if (contadorEnCurso == 0)
                                {
                                    Console.WriteLine("No hay ninguna misión actualmente en curso.");
                                }
                            }
                            break;

                        case 5:
                            if (cantidadMisiones == 0)
                            {
                                Console.WriteLine("No hay misiones registradas");
                            }
                            else
                            {
                                Console.WriteLine("--- MISION MAS CARGADITA ---");
                                int maxObjetos = 0;
                                for (int i = 0; i < cantidadMisiones; i++)
                                {
                                    if (misiones[i, 2] > maxObjetos)
                                    {
                                        maxObjetos = misiones[i, 2];
                                    }
                                }
                                Console.WriteLine($"Maxima cantidad de objetos detectada: {maxObjetos}");
                                for (int i = 0; i < cantidadMisiones; i++)
                                {
                                    if (misiones[i, 2] == maxObjetos)
                                    {
                                        string nombreMapa = "";
                                        if (misiones[i, 1] == 1) nombreMapa = "Hagwarts";
                                        if (misiones[i, 1] == 2) nombreMapa = "La Casa del Viejo";
                                        if (misiones[i, 1] == 3) nombreMapa = "El Laboratorio";

                                        Console.WriteLine($"-> ID: {misiones[i, 0]} | Mapa: {nombreMapa} | Peligro: {misiones[i, 3]}");
                                    }
                                }
                            }
                            break;

                        case 6:
                            if (cantidadMisiones == 0)
                            {
                                Console.WriteLine("No hay misiones cargadas para calcular promedios");
                            }
                            else
                            {
                                Console.WriteLine("--- PROMEDIO DE PELIGRO POR MAPA ---");

                                float sumaPeligroM1 = 0;
                                int cantMisionesM1 = 0;

                                float sumaPeligroM2 = 0;
                                int cantMisionesM2 = 0;

                                float sumaPeligroM3 = 0;
                                int cantMisionesM3 = 0;

                                for (int i = 0; i < cantidadMisiones; i++)
                                {
                                    if (misiones[i, 1] == 1)
                                    {
                                        sumaPeligroM1 += misiones[i, 3];
                                        cantMisionesM1++;
                                    }
                                    else if (misiones[i, 1] == 2)
                                    {
                                        sumaPeligroM2 += misiones[i, 3];
                                        cantMisionesM2++;
                                    }
                                    else if (misiones[i, 1] == 3)
                                    {
                                        sumaPeligroM3 += misiones[i, 3];
                                        cantMisionesM3++;
                                    }
                                }

                                if (cantMisionesM1 > 0)
                                    Console.WriteLine($"- Hagwarts: {sumaPeligroM1 / cantMisionesM1:0.00} promedio de peligro");
                                else
                                    Console.WriteLine("- Hagwarts: Sin misiones");

                                if (cantMisionesM2 > 0)
                                    Console.WriteLine($"- La Casa del Viejo: {sumaPeligroM2 / cantMisionesM2:0.00} promedio de peligro");
                                else
                                    Console.WriteLine("- La Casa del Viejo: Sin misiones");

                                if (cantMisionesM3 > 0)
                                    Console.WriteLine($"- El Laboratorio: {sumaPeligroM3 / cantMisionesM3:0.00} promedio de peligro");
                                else
                                    Console.WriteLine("- El Laboratorio: Sin misiones");
                            }
                            break;

                        case 7:
                            if (cantidadMisiones == 0)
                            {
                                Console.WriteLine("No hay misiones registradas");
                            }
                            else
                            {
                                Console.WriteLine("--- FILTRAR POR MAPA ---");

                                int mapaFiltrar = 0;
                                bool filtroValido = false;
                                while (filtroValido == false)
                                {
                                    Console.Write("Ingrese el mapa a filtrar (1 = Hagwarts, 2 = La Casa del Viejo, 3 = El Laboratorio): ");
                                    mapaFiltrar = int.Parse(Console.ReadLine());

                                    if (mapaFiltrar >= 1 && mapaFiltrar <= 3)
                                    {
                                        filtroValido = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ese mapa no es de este juegazo. Intente de nuevo.");
                                    }
                                }

                                int misionesEncontradas = 0;
                                for (int i = 0; i < cantidadMisiones; i++)
                                {
                                    if (misiones[i, 1] == mapaFiltrar)
                                    {
                                        string nombreEstado = "";
                                        if (misiones[i, 4] == 0) nombreEstado = "Pendiente";
                                        if (misiones[i, 4] == 1) nombreEstado = "En curso";
                                        if (misiones[i, 4] == 2) nombreEstado = "Finalizado";

                                        Console.WriteLine($"ID: {misiones[i, 0]} | Objetos: {misiones[i, 2]} | Peligro: {misiones[i, 3]} | Estado: {nombreEstado}");
                                        misionesEncontradas++;
                                    }
                                }

                                if (misionesEncontradas == 0)
                                {
                                    Console.WriteLine("No se encontraron misiones registradas para este mapa");
                                }
                            }
                            break;

                        case 8:
                            Console.WriteLine("Saliendo del sistema Esperemos que el PERO no sea letal porque te rompemos la gorra");
                            break;

                        default:
                            Console.WriteLine("Opcion no valida Intente de nuevo.");
                            break;
                    }

                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();

                } while (opcion != 8);
            }
        }
    }