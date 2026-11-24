using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ElEterNota
{
    class Program
    {
        const int MAX_REFUGIOS = 20;
        const int COLUMNAS = 5; 

        static void Main(string[] args)
        {
            int[,] refugios = new int[MAX_REFUGIOS, COLUMNAS];
            int cantidad = 0;
            int opcion;

            do
            {
                Console.Clear();
                MostrarMenu();
                opcion = LeerEntero("Opción: ");

                switch (opcion)
                {
                    case 1:
                        AgregarRefugio(refugios, ref cantidad);
                        break;
                    case 2:
                        MostrarTodos(refugios, cantidad);
                        break;
                    case 3:
                        OcuparRefugio(refugios, cantidad);
                        break;
                    case 4:
                        MostrarOcupados(refugios, cantidad);
                        break;
                    case 5:
                        MostrarMayorSuministros(refugios, cantidad);
                        break;
                    case 6:
                        MostrarPromedioPorZona(refugios, cantidad);
                        break;
                    case 7:
                        FiltrarPorZona(refugios, cantidad);
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
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

        static void MostrarMenu()
        {
            Console.WriteLine("==== MENÚ DEL ETERNOTA ====");
            Console.WriteLine("1. Agregar refugio");
            Console.WriteLine("2. Mostrar todos los refugios");
            Console.WriteLine("3. Ocupar refugio");
            Console.WriteLine("4. Mostrar ocupados");
            Console.WriteLine("5. Refugio con más suministros");
            Console.WriteLine("6. Promedio por zona");
            Console.WriteLine("7. Filtrar por zona");
            Console.WriteLine("8. Salir");
        }

        static int LeerEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Ingrese un número válido: ");
            }
            return valor;
        }

        static bool ExisteCodigo(int[,] refugios, int cantidad, int codigo)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (refugios[i, 0] == codigo)
                {
                    return true;
                }
            }
            return false;
        }

        static string NombreZona(int zona)
        {
            switch (zona)
            {
                case 1: return "NORTE";
                case 2: return "SUR";
                case 3: return "OESTE";
                case 4: return "CENTRO";
                default: return "DESCONOCIDA";
            }
        }

        static void AgregarRefugio(int[,] refugios, ref int cantidad)
        {
            if (cantidad >= MAX_REFUGIOS)
            {
                Console.WriteLine("No hay refugios... ¡Vamos a morir!");
                return;
            }

            int codigo;
            do
            {
                codigo = LeerEntero("Codigo del refugio: ");
                if (ExisteCodigo(refugios, cantidad, codigo))
                {
                    Console.WriteLine("Ese codigo ya existe");
                }
            } while (ExisteCodigo(refugios, cantidad, codigo));

            int capacidad;
            do
            {
                capacidad = LeerEntero("Capacidad maxima: ");
                if (capacidad <= 0)
                {
                    Console.WriteLine("No se puede sobrevivir mientras debas wachin");
                }
            } while (capacidad <= 0);

            int suministros;
            do
            {
                suministros = LeerEntero("Suministros disponibles: ");
                if (suministros <= 0)
                {
                    Console.WriteLine("No se puede sobrevivir debiendo pedazo de bigote");
                }
            } while (suministros <= 0);

            int zona;
            do
            {
                Console.WriteLine("1- NORTE");
                Console.WriteLine("2- SUR");
                Console.WriteLine("3- OESTE");
                Console.WriteLine("4- CENTRO");
                zona = LeerEntero("Zona: ");

                if (zona < 1 || zona > 4)
                {
                    Console.WriteLine("Zona invalida, esa parte ya está perdida");
                }
            } while (zona < 1 || zona > 4);

            refugios[cantidad, 0] = codigo;
            refugios[cantidad, 1] = capacidad;
            refugios[cantidad, 2] = suministros;
            refugios[cantidad, 3] = zona;
            refugios[cantidad, 4] = 0;

            cantidad++;
            Console.WriteLine("Refugio agregado correctamente");
        }

        static void MostrarTodos(int[,] refugios, int cantidad)
        {
            if (cantidad == 0)
            {
                Console.WriteLine("No hay refugios registrados");
                return;
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(
                    "Codigo: " + refugios[i, 0] +
                    " | Capacidad: " + refugios[i, 1] +
                    " | Suministros: " + refugios[i, 2] +
                    " | Zona: " + NombreZona(refugios[i, 3]) +
                    " | Ocupado: " + refugios[i, 4]
                );
            }
        }

        static void OcuparRefugio(int[,] refugios, int cantidad)
        {
            Console.WriteLine("Refugios Libres: ");
            bool hayLibres = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (refugios[i, 4] == 0)
                {
                    Console.WriteLine(
                        "Código: " + refugios[i, 0] +
                        " | Capacidad: " + refugios[i, 1] +
                        " | Zona: " + NombreZona(refugios[i, 3])
                    );
                    hayLibres = true;
                }
            }

            if (!hayLibres)
            {
                Console.WriteLine("No hay refugios libres");
                return;
            }

            int codigoOcupar = LeerEntero("Ingrese el código del refugio: ");
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
                        Console.WriteLine("Refugio ocupado correctamente");
                    }
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No existe ese refugio");
            }
        }

        static void MostrarOcupados(int[,] refugios, int cantidad)
        {
            bool hayOcupados = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (refugios[i, 4] == 1)
                {
                    Console.WriteLine(
                        "Codigo: " + refugios[i, 0] +
                        " | Capacidad: " + refugios[i, 1] +
                        " | Suministros: " + refugios[i, 2] +
                        " | Zona: " + NombreZona(refugios[i, 3])
                    );
                    hayOcupados = true;
                }
            }

            if (!hayOcupados)
            {
                Console.WriteLine("No hay refugios ocupados");
            }
        }

        static void MostrarMayorSuministros(int[,] refugios, int cantidad)
        {
            if (cantidad == 0)
            {
                Console.WriteLine("No hay refugios registrados");
                return;
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
        }

        static void MostrarPromedioPorZona(int[,] refugios, int cantidad)
        {
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
                    Console.WriteLine("Zona " + NombreZona(zona) + ": promedio de capacidad = " + promedio);
                }
                else
                {
                    Console.WriteLine("Zona " + NombreZona(zona) + ": no hay refugios");
                }
            }
        }

        static void FiltrarPorZona(int[,] refugios, int cantidad)
        {
            int zonaBuscar = LeerEntero("Ingrese la zona (1 a 4): ");

            if (zonaBuscar < 1 || zonaBuscar > 4)
            {
                Console.WriteLine("Zona invalida esa parte ya está perdida");
                return;
            }

            bool encontradoZona = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (refugios[i, 3] == zonaBuscar)
                {
                    Console.WriteLine(
                        "Codigo: " + refugios[i, 0] +
                        " | Capacidad: " + refugios[i, 1] +
                        " | Suministros: " + refugios[i, 2] +
                        " | Ocupado: " + refugios[i, 4]
                    );
                    encontradoZona = true;
                }
            }

            if (!encontradoZona)
            {
                Console.WriteLine("No hay refugios en esa zona");
            }
        }
    }
}