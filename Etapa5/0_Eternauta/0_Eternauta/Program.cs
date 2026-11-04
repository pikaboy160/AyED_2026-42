using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Eternauta
{
    class Program
    {
        static void Main(string[] args)
        {
            Refugio refugio101 = new Refugio(101, 20, 12);
            Refugio refugio102 = new Refugio(102, 15, 10);
            Refugio refugio103 = new Refugio(103, 30, 25);

            Console.WriteLine("Hay un Total de: " + refugio101.CalcularDisponibles() + " Espacios Disponibles ");
            refugio101.MostrarInformacion();
            Console.WriteLine("");
            Console.WriteLine("Hay un Total de: " + refugio102.CalcularDisponibles() + " Espacios Disponibles ");
            refugio102.MostrarInformacion();
            Console.WriteLine("");
            Console.WriteLine("Hay un Total de: " + refugio103.CalcularDisponibles() + " Espacios Disponibles ");
            refugio103.MostrarInformacion();
            Console.WriteLine("");
            Console.WriteLine("---RESUMEN---");
            Console.WriteLine("Personas Alojadas: " + (refugio101.getPersonasAlojadas() + refugio102.getPersonasAlojadas() + refugio103.getPersonasAlojadas()));
            Console.WriteLine("Lugares Disponibles: " + (refugio101.CalcularDisponibles() + refugio102.CalcularDisponibles() + refugio103.CalcularDisponibles()));

            Refugio refugioMayor = refugio101;

            if (refugio102.EsMayorCapacidadQue(refugioMayor))
            {
                refugioMayor = refugio102;
            }

            if (refugio103.EsMayorCapacidadQue(refugioMayor))
            {
                refugioMayor = refugio103;
            }

            Console.WriteLine("El refugio con mayor capacidad es: " + (refugioMayor.ObtenerCodigo()));

            Console.ReadKey();
        }
    }

    class Refugio
    {
        // Atributos
        private int Codigo;
        private int CapacidadMaxima;
        private int PersonasAlojadas;

        // Constructor
        public Refugio(int codigo, int capacidadMaxima, int personasAlojadas)
        {
            this.Codigo = codigo;
            this.CapacidadMaxima = capacidadMaxima;
            this.PersonasAlojadas = personasAlojadas;
        }

        public int CalcularDisponibles()
        {
            return CapacidadMaxima - PersonasAlojadas;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Codigo del Refugio: " + Codigo);
            Console.WriteLine("Hay una Capacidad Maxima de: " + CapacidadMaxima);
            Console.WriteLine("Y hay un Total de: " + PersonasAlojadas + " Personas Alojadas ");
            Console.WriteLine("Habiendo un Total de: " + CalcularDisponibles() + " Lugares disponibles");
        }

        public int ObtenerCodigo()
        {
            return Codigo;
        }

        public int getPersonasAlojadas()
        {
            return PersonasAlojadas;
        }

        public bool EsMayorCapacidadQue(Refugio otroRefugio)
        {
            if (this.CapacidadMaxima > otroRefugio.CapacidadMaxima)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}