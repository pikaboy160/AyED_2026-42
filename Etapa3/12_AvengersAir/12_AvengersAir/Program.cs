using System;
using System;

namespace AvengersAirConsole
{
    class Program
    {
        static int[] numeros = new int[80];
        static string[] tipos = new string[80];
        static string[] ubicaciones = new string[80];
        static double[] precios = new double[80];
        static bool[] ocupados = new bool[80];

        static string[] nombres = new string[80];
        static string[] apellidos = new string[80];
        static int[] edades = new int[80];
        static string[] dnis = new string[80];
        static string[] nacionalidades = new string[80];

        static void Main(string[] args)
        {
            for (int i = 0; i < 80; i++)
            {
                numeros[i] = i + 1;
                ocupados[i] = false;

                if (numeros[i] <= 20)
                {
                    tipos[i] = "Primera Clase";
                    precios[i] = 200;
                }
                else if (numeros[i] == 40 || numeros[i] == 41 || numeros[i] == 42 || numeros[i] == 43)
                {
                    tipos[i] = "Salida de Emergencia";
                    precios[i] = 80;
                }
                else
                {
                    tipos[i] = "Economica";
                    precios[i] = 100;
                }

                if (numeros[i] % 2 == 0)
                {
                    ubicaciones[i] = "Ventana";
                }
                else
                {
                    ubicaciones[i] = "Pasillo";
                }
            }

            int opcion = 0;

            while (opcion != 7)
            {
                Console.Clear();

                int disponibles = 0;
                int ocupadosCant = 0;
                for (int i = 0; i < 80; i++)
                {
                    if (ocupados[i]) ocupadosCant++;
                    else disponibles++;
                }

                Console.WriteLine("=================================================================");
                Console.WriteLine("   Menu Principal AvengersAir - Vuelo Buenos Aires a Wakanda   ");
                Console.WriteLine("=================================================================");
                Console.WriteLine("Asientos Disponibles: " + disponibles + "Asientos Ocupados: " + ocupadosCant + "");
                Console.WriteLine("1. Vender Asiento");
                Console.WriteLine("2. Devolver Asiento");
                Console.WriteLine("3. Modificar Asiento");
                Console.WriteLine("4. Calcular Ventas");
                Console.WriteLine("5. Buscar Pasajeros por Edad");
                Console.WriteLine("6. Obtener Asientos con DNI Par");
                Console.WriteLine("7. Salir");
                Console.WriteLine("=================================================================");
                Console.Write("Ingrese la opción deseada: ");

                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch
                {
                    opcion = 0; 
                }

                switch (opcion)
                {
                    case 1:
                        VenderAsiento();
                        break;
                    case 2:
                        DevolverAsiento();
                        break;
                    case 3:
                        ModificarAsiento();
                        break;
                    case 4:
                        CalcularVentas();
                        break;
                    case 5:
                        BuscarPasajerosPorEdad();
                        break;
                    case 6:
                        ObtenerAsientosDniPar();
                        break;
                    case 7:
                        Console.WriteLine("Gracias por volar con AvengersAir Buen viaje a Wakanda ¡Wakanda Forever!");
                        break;
                    default:
                        Console.WriteLine("Opcion no válida. Intente nuevamente");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void VenderAsiento()
        {
            Console.Clear();
            Console.WriteLine(" VENDER ASIENTO ");
            Console.WriteLine("Lista de Asientos Disponibles:");
            Console.WriteLine("| N° Asiento | Tipo de Asiento | Ubicación | Precio |");

            for (int i = 0; i < 80; i++)
            {
                if (ocupados[i] == false)
                {
                    Console.WriteLine(" " + numeros[i] + " " + tipos[i] + " " + ubicaciones[i] + " $" + precios[i] + " ");
                }
            }

            Console.Write("Ingrese el número de asiento que desea vender (1-80): ");
            int numAsiento = 0;

            try
            {
                numAsiento = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("mal Debe ingresar un numero pedazo de bobi");
                Console.ReadLine();
                return;
            }

            if (numAsiento >= 1 && numAsiento <= 80)
            {
                int index = numAsiento - 1; 

                if (ocupados[index])
                {
                    Console.WriteLine("mal Ese asiento ya se encuentra ocupado.");
                }
                else
                {
                    Console.WriteLine("Asiento seleccionado: " + numeros[index] + " (" + tipos[index] + ")");

                    Console.Write("Ingrese Nombre del pasajero: ");
                    nombres[index] = Console.ReadLine();

                    Console.Write("Ingrese Apellido del pasajero: ");
                    apellidos[index] = Console.ReadLine();

                    Console.Write("Ingrese Edad del pasajero: ");
                    try
                    {
                        edades[index] = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        edades[index] = 0;
                    }

                    Console.Write("Ingrese DNI del pasajero (solo numeros): ");
                    dnis[index] = Console.ReadLine();

                    Console.Write("Ingrese Nacionalidad del pasajero: ");
                    nacionalidades[index] = Console.ReadLine();

                    ocupados[index] = true;

                    Console.WriteLine("Venta registrada con éxito");
                }
            }
            else
            {
                Console.WriteLine("Numero de asiento invalido");
            }

            Console.WriteLine("Presione Enter para volver al menu");
            Console.ReadLine();
        }

        static void DevolverAsiento()
        {
            Console.Clear();
            Console.WriteLine(" DEVOLVER ASIENTO ");
            Console.Write("Ingrese el número de asiento a devolver (1-80): ");

            int numAsiento = 0;
            try
            {
                numAsiento = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("mal Debe ingresar un numero valido pedazo de gato");
                Console.ReadLine();
                return;
            }

            if (numAsiento >= 1 && numAsiento <= 80)
            {
                int index = numAsiento - 1;

                if (ocupados[index])
                {
                    nombres[index] = "";
                    apellidos[index] = "";
                    edades[index] = 0;
                    dnis[index] = "";
                    nacionalidades[index] = "";
                    ocupados[index] = false;

                    Console.WriteLine("El asiento " + numAsiento + " ha sido liberado exitosamente");
                }
                else
                {
                    Console.WriteLine("El asiento está libre y no se realizará ninguna accion adicional");
                }
            }
            else
            {
                Console.WriteLine("\nNúmero de asiento no valido");
            }

            Console.WriteLine("Presione Enter para volver al menu");
            Console.ReadLine();
        }

        static void ModificarAsiento()
        {
            Console.Clear();
            Console.WriteLine(" MODIFICAR ASIENTO ");
            Console.WriteLine("Asientos Ocupados actualmente:\n");

            Console.WriteLine("| N° | Tipo | Nombre | Apellido | Edad | DNI | Nacionalidad |");

            bool hayOcupados = false;
            for (int i = 0; i < 80; i++)
            {
                if (ocupados[i])
                {
                    Console.WriteLine(" " + numeros[i] + "  " + tipos[i] + "  " + nombres[i] + "  " + apellidos[i] + "  " + edades[i] + "  " + dnis[i] + "  " + nacionalidades[i] + " ");
                    hayOcupados = true;
                }
            }

            if (hayOcupados == false)
            {
                Console.WriteLine("No hay ningun asiento ocupado en este momento");
                Console.WriteLine("\nPresione Enter para volver al menu");
                Console.ReadLine();
                return;
            }

            Console.Write("\nIngrese el número de asiento que desea modificar: ");

            int numAsiento = 0;
            try
            {
                numAsiento = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("esta mal Debe ingresar un numero valido pedazo de bigote");
                Console.ReadLine();
                return;
            }

            if (numAsiento >= 1 && numAsiento <= 80)
            {
                int index = numAsiento - 1;

                if (ocupados[index])
                {
                    Console.WriteLine("Modificando Pasajero del Asiento " + numAsiento + ":");

                    Console.Write("Nuevo Nombre (Actual: " + nombres[index] + "): ");
                    string nuevoNombre = Console.ReadLine();
                    if (nuevoNombre != "") nombres[index] = nuevoNombre;

                    Console.Write("Nuevo Apellido (Actual: " + apellidos[index] + "): ");
                    string nuevoApellido = Console.ReadLine();
                    if (nuevoApellido != "") apellidos[index] = nuevoApellido;

                    Console.Write("Nueva Edad (Actual: " + edades[index] + "): ");
                    string nuevaEdadStr = Console.ReadLine();
                    if (nuevaEdadStr != "")
                    {
                        try
                        {
                            edades[index] = int.Parse(nuevaEdadStr);
                        }
                        catch
                        {

                        }
                    }

                    Console.Write("Nuevo DNI (Actual: " + dnis[index] + "): ");
                    string nuevoDni = Console.ReadLine();
                    if (nuevoDni != "") dnis[index] = nuevoDni;

                    Console.Write("Nueva Nacionalidad (Actual: " + nacionalidades[index] + "): ");
                    string nuevaNac = Console.ReadLine();
                    if (nuevaNac != "") nacionalidades[index] = nuevaNac;

                    Console.WriteLine("Información modificada correctamente");
                }
                else
                {
                    Console.WriteLine("Ese asiento no está vendido, por ende no se puede modificar");
                }
            }
            else
            {
                Console.WriteLine("Asiento inválido.");
            }

            Console.WriteLine("Presione Enter para volver al menú...");
            Console.ReadLine();
        }

        static void CalcularVentas()
        {
            Console.Clear();
            Console.WriteLine(" CALCULAR VENTAS ");

            double totalPrimeraClase = 0;
            double totalEmergencia = 0;
            double totalEconomica = 0;
            double recaudacionTotal = 0;

            for (int i = 0; i < 80; i++)
            {
                if (ocupados[i])
                {
                    recaudacionTotal += precios[i];
                    if (tipos[i] == "Primera Clase") totalPrimeraClase += precios[i];
                    else if (tipos[i] == "Salida de Emergencia") totalEmergencia += precios[i];
                    else totalEconomica += precios[i];
                }
            }

            Console.WriteLine("Recaudacion por Primera Clase ($200 c/u):  $" + totalPrimeraClase);
            Console.WriteLine("Recaudacion por Salidas de Emergencia ($80 c/u): $" + totalEmergencia);
            Console.WriteLine("Recaudacion por Clase Economica ($100 c/u):      $" + totalEconomica);
            Console.WriteLine("RECAUDACION TOTAL DEL VUELO:              $" + recaudacionTotal);

            Console.WriteLine("Presione Enter para volver al menu");
            Console.ReadLine();
        }

        static void BuscarPasajerosPorEdad()
        {
            Console.Clear();
            Console.WriteLine(" PASAJEROS POR EDAD ");
            Console.Write("Ingrese la edad a buscar: ");

            int edadBuscada = 0;
            try
            {
                edadBuscada = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Por favor, ingrese un número válido para la edad");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Pasajeros con " + edadBuscada + " años encontrados:");

            bool encontrados = false;
            for (int i = 0; i < 80; i++)
            {
                if (ocupados[i] && edades[i] == edadBuscada)
                {
                    Console.WriteLine($" Asiento N° " + numeros[i] + " (" + tipos[i] + "): " + nombres[i] + " " + apellidos[i] + " DNI: " + dnis[i]);
                    encontrados = true;
                }
            }

            if (encontrados == false)
            {
                Console.WriteLine("No se encontraron pasajeros con esa edad");
            }

            Console.WriteLine("Presione Enter para volver al menu");
            Console.ReadLine();
        }

        static void ObtenerAsientosDniPar()
        {
            Console.Clear();
            Console.WriteLine(" ASIENTOS CON PASAJEROS DE DNI PAR ");

            bool encontrados = false;
            for (int i = 0; i < 80; i++)
            {
                if (ocupados[i])
                {
                    try
                    {
                        long dniNumero = long.Parse(dnis[i]);
                        if (dniNumero % 2 == 0)
                        {
                            Console.WriteLine($" Asiento N° " + numeros[i] + " (" + tipos[i] + ")  Pasajero: " + nombres[i] + " " + apellidos[i] + "  DNI: " + dnis[i]);
                            encontrados = true;
                        }
                    }
                    catch
                    {
                    }
                }
            }

            if (encontrados == false)
            {
                Console.WriteLine("No se encontraron pasajeros con DNI par en este vuelo");
            }

            Console.WriteLine("Presione Enter para volver al menu");
            Console.ReadLine();
        }
        
    }
}