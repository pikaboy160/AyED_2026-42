using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ElEterNota
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] refugios = new int[20, 5];
            int cantidad = 0;
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ DEL ETERNOTA ====");
                Console.WriteLine("1. Agregar refugio");
                Console.WriteLine("2. Mostrar todos los refugios");
                Console.WriteLine("3. Ocupar refugio");
                Console.WriteLine("4. Mostrar ocupados");
                Console.WriteLine("5. Refugio con más suministros");
                Console.WriteLine("6. Promedio por zona");
                Console.WriteLine("7. Filtrar por zona");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)

                {
                    case 1:
                        if (cantidad >= 20)
                        {
                            Console.WriteLine("No hay refugios... ¡Vamos a morir!");
                            break;
                        }

                        bool correcto = false;

                        while (!correcto)
                        {
                            Console.Write("Codigo del refugio: ");
                            int codigo = int.Parse(Console.ReadLine());

                            bool repetido = false;

                            for (int i = 0; i < cantidad; i++)
                            {
                                if (refugios[i, 0] == codigo)
                                {
                                    repetido = true;
                                }
                            }

                            if (repetido)
                            {
                                Console.WriteLine("Ese codigo ya existe ");
                            }
                            else
                            {
                                refugios[cantidad, 0] = codigo;
                                correcto = true;
                            }
                        }

                        correcto = false;

                        while (!correcto)
                        {
                            Console.Write("Capacidad maxima: ");
                            int capacidad = int.Parse(Console.ReadLine());

                            if (capacidad > 0)
                            {
                                refugios[cantidad, 1] = capacidad;
                                correcto = true;
                            }
                            else
                            {
                                Console.WriteLine("No se puede sobrevivir mientras debas wachin");
                            }
                        }

                        correcto = false;

                        while (!correcto)
                        {
                            Console.Write("Suministros disponibles: ");
                            int suministros = int.Parse(Console.ReadLine());

                            if (suministros > 0)
                            {
                                refugios[cantidad, 2] = suministros;
                                correcto = true;
                            }
                            else
                            {
                                Console.WriteLine("No se puede sobrevivir debiendo pedazo de bigote");
                            }
                        }

                        correcto = false;

                        while (!correcto)
                        {
                            Console.WriteLine("1- NORTE");
                            Console.WriteLine("2- SUR");
                            Console.WriteLine("3- OESTE");
                            Console.WriteLine("4- CENTRO");
                            Console.Write("Zona: ");

                            int zona = int.Parse(Console.ReadLine());

                            if (zona >= 1 && zona <= 4)
                            {
                                refugios[cantidad, 3] = zona;
                                correcto = true;
                            }
                            else
                            {
                                Console.WriteLine("Zona invalida, esa parte ya está perdida");
                            }
                        }

                        refugios[cantidad, 4] = 0;

                        cantidad++;

                        Console.WriteLine("Refugio agregado correctamente ");

                        break;


                    case 2:

                        if (cantidad == 0)
                        {
                            Console.WriteLine("No hay refugios registrados ");
                        }

                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Codigo: " + refugios[i, 0] + " | Capacidad: " + refugios[i, 1] + " | Suministros: " + refugios[i, 2] + " | Zona: " + refugios[i, 3] + " | Ocupado: " + refugios[i, 4]);
                        }

                        break;


                    case 3:

                        Console.WriteLine("Refugios Libres: ");

                        bool hayLibres = false;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (refugios[i, 4] == 0)
                            {
                                Console.WriteLine("Código: " + refugios[i, 0] + " | Capacidad: " + refugios[1, 1] + " | Zona: " + refugios[i, 3]);

                                hayLibres = true;
                            }
                        }

                        if (!hayLibres)
                        {
                            Console.WriteLine("No hay refugios libres ");
                            break;
                        }

                        Console.Write("Ingrese el código del refugio: ");
                        int codigoOcupar = int.Parse(Console.ReadLine());

                        bool encontrado = false;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (refugios[i, 0] == codigoOcupar)
                            {
                                encontrado = true;

                                if (refugios[i, 4] == 1)
                                {
                                    Console.WriteLine("No somos Okupas (terrible mentira) esto ya esta ocupado");
                                }
                                else
                                {
                                    refugios[i, 4] = 1;
                                    Console.WriteLine("Refugio ocupado correctamente ");
                                }
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No existe ese refugio ");
                        }

                        break;


                    case 4:

                        bool hayOcupados = false;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (refugios[i, 4] == 1)
                            {
                                Console.WriteLine("Codigo: " + refugios[i, 0] + " | Capacidad: " + refugios[i, 1] + " | Suministros: " + refugios[i, 2] + " | Zona: " + refugios[i, 3]);
                                hayOcupados = true;
                            }
                        }

                        if (!hayOcupados)
                        {
                            Console.WriteLine("No hay refugios ocupados ");

                        }

                        break;


                    case 5:

                        if (cantidad == 0)
                        {
                            Console.WriteLine("No hay refugios registrados ");
                            break;
                        }

                        int mayor = refugios[0, 2];

                        for (int i = 1; i < cantidad; i++)
                        {
                            if (refugios[i, 2] > mayor)
                            {
                                mayor = refugios[i, 2];
                            }
                        }

                        Console.WriteLine("Refugios con mas suministros: ");

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (refugios[i, 2] == mayor)
                            {
                                Console.WriteLine("Codigo: " + refugios[i, 0] + " | Suministros: " + refugios[i, 2]);
                            }
                        }

                        break;


                    case 6:

                        for (int zona = 1; zona <= 4; zona++)
                        {
                            int suma = 0;
                            int contador = 0;

                            for (int i = 0; i < cantidad; i++)
                            {
                                if (refugios[i, 3] == zona)
                                {
                                    suma += refugios[i, 1];
                                    contador++;
                                }
                            }

                            if (contador > 0)
                            {
                                double promedio = (double)suma / contador;

                                Console.WriteLine("Zona " + zona + ": promedio de capacidad = " + promedio);
                            }
                            else
                            {
                                Console.WriteLine("Zona " + zona + ": no hay refugios ");
                            }
                        }

                        break;


                    case 7:

                        Console.Write("Ingrese la zona (1 a 4): ");
                        int zonaBuscar = int.Parse(Console.ReadLine());

                        if (zonaBuscar < 1 || zonaBuscar > 4)
                        {
                            Console.WriteLine("Zona invalida esa parte ya está perdida");
                            break;
                        }

                        bool encontradoZona = false;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (refugios[i, 3] == zonaBuscar)
                            {
                                Console.WriteLine("Codigo: " + refugios[i, 0] + " | Capacidad: " + refugios[i, 1] + " | Suministros: " + refugios[i, 2] + " | Ocupado: " + refugios[i, 4]);

                                encontradoZona = true;
                            }
                        }

                        if (!encontradoZona)
                        {
                            Console.WriteLine("No hay refugios en esa zona ");
                        }

                        break;


                    case 8:

                        Console.WriteLine(
                            "Saliendo del sistema... ¡Que la nevada no te atrape!");

                        break;


                    default:

                        Console.WriteLine("Opción no válida. Intente de nuevo.");

                        break;
                }

                if (opcion != 8)
                {
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 8);
        }
    }
}
