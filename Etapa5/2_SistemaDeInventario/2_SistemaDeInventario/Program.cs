using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SistemaDeInventario
{
    class ObjetoMinecraft
    {
        public int id;
        public string nombre;
        public string material;
        public bool crafteable;
        public int stackMaximo;
        public int usosRestantes;

        public ObjetoMinecraft(int id, string nombre, string material, bool crafteable, int stackMaximo, int usosRestantes)
        {
            this.id = id;
            this.nombre = nombre;
            this.material = material;
            this.crafteable = crafteable;
            this.stackMaximo = stackMaximo;
            this.usosRestantes = usosRestantes;
        }

        public ObjetoMinecraft Clonar()
        {
            return new ObjetoMinecraft(id, nombre, material, crafteable, stackMaximo, usosRestantes);
        }

        public bool UsarUnaVez()
        {
            if (usosRestantes > 0)
            {
                usosRestantes--;
            }
            return usosRestantes <= 0;
        }

        public void MostrarInfo()
        {
            string estadoCraft = crafteable ? "Sí" : "No";
            Console.Write($"[ID: {id}] {nombre} ({material}) | Crafteable: {estadoCraft} | Stack máx: {stackMaximo} | Usos: {usosRestantes}");
        }
    }

    class Program
    {
        const int Tamaño_invertario = 9;

        static void Main(string[] args)
        {
            ObjetoMinecraft[] slotsObjetos = new ObjetoMinecraft[Tamaño_invertario];
            int[] slotsCantidades = new int[Tamaño_invertario];

            bool salir = false;

            while (!salir)
            {
                MostrarMenu();
                int opcion = LeerIntEnRango("Elegí una opción (1-6): ", 1, 6);

                switch (opcion)
                {
                    case 1:
                        AgregarObjeto(slotsObjetos, slotsCantidades);
                        break;
                    case 2:
                        MostrarInventario(slotsObjetos, slotsCantidades);
                        break;
                    case 3:
                        UtilizarObjeto(slotsObjetos, slotsCantidades);
                        break;
                    case 4:
                        EliminarObjetos(slotsObjetos, slotsCantidades);
                        break;
                    case 5:
                        MostrarEstadisticas(slotsObjetos, slotsCantidades);
                        break;
                    case 6:
                        salir = true;
                        Console.WriteLine("Saliendo del inventario...");
                        break;
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Barra del inventardo del minecra");
            Console.WriteLine("1) Agregar objetos");
            Console.WriteLine("2) Mostrar inventario");
            Console.WriteLine("3) Utilizar objeto");
            Console.WriteLine("4) Eliminar objetos");
            Console.WriteLine("5) Consultar estadísticas");
            Console.WriteLine("6) Salir");
        }

        static void AgregarObjeto(ObjetoMinecraft[] objetos, int[] cantidades)
        {
            int id = LeerIntMayorQueCero("ID del objeto: ");
            string nombre = LeerTextoNoVacio("Nombre del objeto: ");
            string material = LeerTextoNoVacio("Material: ");
            bool crafteable = LeerBool("Es crafteable ?: ");
            int stackMax = LeerStackMaximo("Stack máximo (1, 8, 16 o 64): ");
            int usos = LeerIntMayorQueCero("Usos restantes: ");
            int cantidadAgregar = LeerIntMayorQueCero("Cantidad de unidades a agregar: ");

            for (int i = 0; i < Tamaño_invertario; i++)
            {
                if (objetos[i] != null && objetos[i].id == id && objetos[i].stackMaximo != stackMax)
                {
                    Console.WriteLine("Error: ya existe ese ID con un stack máximo diferente.");
                    return;
                }
            }

            int capacidadDisponible = CalcularCapacidadDisponible(objetos, cantidades, id, stackMax);

            if (cantidadAgregar > capacidadDisponible)
            {
                Console.WriteLine($"Operación rechazada: no hay espacio suficiente. Solo caben {capacidadDisponible} unidades y pediste {cantidadAgregar}.");
                return;
            }

            int restantes = cantidadAgregar;

            for (int i = 0; i < Tamaño_invertario && restantes > 0; i++)
            {
                if (objetos[i] != null && objetos[i].id == id && cantidades[i] < objetos[i].stackMaximo)
                {
                    int hueco = objetos[i].stackMaximo - cantidades[i];
                    int aPoner = restantes < hueco ? restantes : hueco;
                    cantidades[i] += aPoner;
                    restantes -= aPoner;
                }
            }

            for (int i = 0; i < Tamaño_invertario && restantes > 0; i++)
            {
                if (objetos[i] == null)
                {
                    int aPoner = restantes < stackMax ? restantes : stackMax;
                    objetos[i] = new ObjetoMinecraft(id, nombre, material, crafteable, stackMax, usos);
                    cantidades[i] = aPoner;
                    restantes -= aPoner;
                }
            }

            Console.WriteLine($"Se agregaron {cantidadAgregar} unidad(es) de '{nombre}' correctamente.");
        }

        static int CalcularCapacidadDisponible(ObjetoMinecraft[] objetos, int[] cantidades, int id, int stackMax)
        {
            int totalCapacidad = 0;

            for (int i = 0; i < Tamaño_invertario; i++)
            {
                if (objetos[i] == null)
                {
                    totalCapacidad += stackMax;
                }
                else if (objetos[i].id == id && cantidades[i] < objetos[i].stackMaximo)
                {
                    totalCapacidad += objetos[i].stackMaximo - cantidades[i];
                }
            }

            return totalCapacidad;
        }

        static void MostrarInventario(ObjetoMinecraft[] objetos, int[] cantidades)
        {
            Console.WriteLine("\n--- INVENTARIO (9 POSICIONES) ---");
            for (int i = 0; i < Tamaño_invertario; i++)
            {
                Console.Write($"Slot {i + 1}: ");
                if (objetos[i] == null || cantidades[i] <= 0)
                {
                    Console.WriteLine("[VACÍO]");
                }
                else
                {
                    objetos[i].MostrarInfo();
                    Console.WriteLine($" | Cantidad: {cantidades[i]}");
                }
            }
        }

        static void UtilizarObjeto(ObjetoMinecraft[] objetos, int[] cantidades)
        {
            int slot = LeerIntEnRango("Elegí la posición a utilizar (1-9): ", 1, Tamaño_invertario) - 1;

            if (objetos[slot] == null || cantidades[slot] <= 0)
            {
                Console.WriteLine("Esa posición está vacía. No hay ningún objeto para utilizar.");
                return;
            }

            bool seRompio = objetos[slot].UsarUnaVez();

            if (seRompio)
            {
                Console.WriteLine($"¡El objeto '{objetos[slot].nombre}' se rompió y desapareció del slot {slot + 1}!");
                LiberarSlot(objetos, cantidades, slot);
            }
            else
            {
                Console.WriteLine($"Usaste '{objetos[slot].nombre}' en el slot {slot + 1}. Usos restantes: {objetos[slot].usosRestantes}");
            }
        }

        static void EliminarObjetos(ObjetoMinecraft[] objetos, int[] cantidades)
        {
            int slot = LeerIntEnRango("Elegí la posición (1-9): ", 1, Tamaño_invertario) - 1;

            if (objetos[slot] == null || cantidades[slot] <= 0)
            {
                Console.WriteLine("Esa posición ya está vacía.");
                return;
            }

            Console.WriteLine($"En el slot {slot + 1} hay {cantidades[slot]} unidad(es) de '{objetos[slot].nombre}'.");
            int aEliminar = LeerIntMayorQueCero("¿Cuántas unidades querés eliminar?: ");

            if (aEliminar > cantidades[slot])
            {
                Console.WriteLine($"Operación rechazada: no podés eliminar {aEliminar} porque solo hay {cantidades[slot]}.");
                return;
            }

            cantidades[slot] -= aEliminar;

            if (cantidades[slot] == 0)
            {
                LiberarSlot(objetos, cantidades, slot);
                Console.WriteLine("Se eliminaron todas las unidades y el slot quedó libre.");
            }
            else
            {
                Console.WriteLine($"Se eliminaron {aEliminar} unidad(es). Quedan {cantidades[slot]} en el slot {slot + 1}.");
            }
        }

        static void LiberarSlot(ObjetoMinecraft[] objetos, int[] cantidades, int indice)
        {
            objetos[indice] = null;
            cantidades[indice] = 0;
        }

        static void MostrarEstadisticas(ObjetoMinecraft[] objetos, int[] cantidades)
        {
            int posicionesOcupadas = 0;
            int espaciosLibres = 0;
            int unidadesAlmacenadas = 0;
            int slotsCrafteables = 0;

            for (int i = 0; i < Tamaño_invertario; i++)
            {
                if (objetos[i] != null && cantidades[i] > 0)
                {
                    posicionesOcupadas++;
                    unidadesAlmacenadas += cantidades[i];
                    if (objetos[i].crafteable)
                    {
                        slotsCrafteables++;
                    }
                }
                else
                {
                    espaciosLibres++;
                }
            }

            Console.WriteLine("\n--- ESTADÍSTICAS DEL INVENTARIO ---");
            Console.WriteLine($"Posiciones ocupadas: {posicionesOcupadas}");
            Console.WriteLine($"Espacios libres: {espaciosLibres}");
            Console.WriteLine($"Total de unidades almacenadas: {unidadesAlmacenadas}");
            Console.WriteLine($"Posiciones con objetos crafteables: {slotsCrafteables}");
        }

        static string LeerTextoNoVacio(string mensaje)
        {
            string texto;
            do
            {
                Console.Write(mensaje);
                texto = Console.ReadLine()?.Trim() ?? "";
                if (string.IsNullOrEmpty(texto))
                {
                    Console.WriteLine("El texto no puede estar vacío.");
                }
            } while (string.IsNullOrEmpty(texto));
            return texto;
        }

        static int LeerIntMayorQueCero(string mensaje)
        {
            int valor;
            bool ok;
            do
            {
                Console.Write(mensaje);
                ok = int.TryParse(Console.ReadLine(), out valor) && valor > 0;
                if (!ok)
                {
                    Console.WriteLine("Ingresá un número entero mayor que 0.");
                }
            } while (!ok);
            return valor;
        }

        static int LeerIntEnRango(string mensaje, int min, int max)
        {
            int valor;
            bool ok;
            do
            {
                Console.Write(mensaje);
                ok = int.TryParse(Console.ReadLine(), out valor) && valor >= min && valor <= max;
                if (!ok)
                {
                    Console.WriteLine($"Ingresá un número entre {min} y {max}.");
                }
            } while (!ok);
            return valor;
        }

        static int LeerStackMaximo(string mensaje)
        {
            int valor;
            bool ok;
            do
            {
                Console.Write(mensaje);
                ok = int.TryParse(Console.ReadLine(), out valor) && (valor == 1 || valor == 8 || valor == 16 || valor == 64);
                if (!ok)
                {
                    Console.WriteLine("El stack máximo solo puede ser 1, 8, 16 o 64.");
                }
            } while (!ok);
            return valor;
        }

        static bool LeerBool(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string entrada = (Console.ReadLine() ?? "").Trim().ToLower();
                if (entrada == "s" || entrada == "si" || entrada == "sí") return true;
                if (entrada == "n" || entrada == "no") return false;
                Console.WriteLine("Respondé con 's' o 'n'.");
            }
        }
    }
}
