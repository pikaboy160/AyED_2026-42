using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AerolineasArgentinas
{
    class Program
    {
        static void Main(string[] args)
        {
            int TOTAL_COMPRAS = 10;
            CompraPasaje[] compras = new CompraPasaje[TOTAL_COMPRAS];

            Console.WriteLine("Sistema de Compra de Pasajes");
            Console.WriteLine("Ingrese los datos de las " + (TOTAL_COMPRAS) + " Compras Porfavor");

            for (int i = 0; i < TOTAL_COMPRAS; i++) 
            {
                Console.Write("Ingrese código de operación: ");
                string Codigo = Console.ReadLine();

                Console.Write("Ingrese nombre del pasajero: ");
                string NombrePasajero = Console.ReadLine();

                Console.Write("Ingrese destino del viaje: ");
                string Destino = Console.ReadLine();

                Console.Write("Ingrese precio individual del pasaje: ");
                double precio = double.Parse(Console.ReadLine());

                Console.Write("Ingrese cantidad de asientos adquiridos: ");
                int cantAsientos = int.Parse(Console.ReadLine());

                compras[i] = new CompraPasaje(Codigo, NombrePasajero, Destino, precio, cantAsientos);

                Console.WriteLine();
            }
            Console.WriteLine("Resumen final de las compras: ");

            for (int i = 0; i < TOTAL_COMPRAS; i++)
            {
                compras[i].MostrarInformacion();
            }

            double recaudacionTotal = 0;
            int totalAsientos = 0;
            int comprasMayor200k = 0;

            double mayorImporte = -1;
            string pasajeroMayorImporte = "";
            string destinoMayorImporte = "";

            for (int i = 0; i < TOTAL_COMPRAS; i++)
            {
                double importeActual = compras[i].ImporteTotal();
                int asientosActuales = compras[i].ObtenerCantidadAsientos();

                recaudacionTotal += importeActual;
                totalAsientos += asientosActuales;

                if (importeActual > mayorImporte)
                {
                    mayorImporte = importeActual;
                    pasajeroMayorImporte = compras[i].ObtenerNombrePasajero();
                    destinoMayorImporte = compras[i].ObtenerDestino();
                }

                if (importeActual > 200000)
                {
                    comprasMayor200k++;
                }
            }

            double importePromedio = recaudacionTotal / TOTAL_COMPRAS;
            double porcentajeMayor200k = ((double)comprasMayor200k / TOTAL_COMPRAS) * 100;

            Console.WriteLine("        INFORME DE ESTADÍSTICAS        ");
            Console.WriteLine($"1 Recaudación total: ${recaudacionTotal}");
            Console.WriteLine($"2 Total de asientos vendidos: {totalAsientos}");
            Console.WriteLine($"3 Importe promedio por compra: ${importePromedio}");
            Console.WriteLine($"4 Pasajero con compra de mayor importe: {pasajeroMayorImporte} (${mayorImporte})");
            Console.WriteLine($"5 Compras que superaron los $200.000: {comprasMayor200k}");
            Console.WriteLine($"6 Porcentaje de compras superiores a $200.000: {porcentajeMayor200k}");
            Console.WriteLine($"7 Destino de la compra de mayor importe: {destinoMayorImporte}");

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }

}
   
        public class CompraPasaje
        {
            private string Codigo;
            private string NombrePasajero;
            private string Destino;
            private double Precio;
            private int CantAsientos;

            public CompraPasaje(string Codigo, string NombrePasajero, string Destino, double Precio, int CantAsientos)
            {
                this.Codigo = Codigo;
                this.NombrePasajero = NombrePasajero;
                this.Destino = Destino;
                this.Precio = Precio;
                this.CantAsientos = CantAsientos;
            }

            public double ImporteTotal()
            {
                return this.Precio * this.CantAsientos;
            }

            public void MostrarInformacion()
            {
                Console.WriteLine($" Código de Operación: " + this.Codigo);
                Console.WriteLine($" Pasajero: " + this.NombrePasajero);
                Console.WriteLine($" Destino: " + this.Destino);
                Console.WriteLine($" Precio Individual: " + this.Precio);
                Console.WriteLine($" Cantidad de Asientos: " + this.CantAsientos);
                Console.WriteLine($" Importe Total: " + ImporteTotal());
            }

            public int ObtenerCantidadAsientos()
            {
                return this.CantAsientos;
            }

            public string ObtenerNombrePasajero()
            {
                return this.NombrePasajero;
            }

            public string ObtenerDestino()
            {
                return this.Destino;
            }

        }
    