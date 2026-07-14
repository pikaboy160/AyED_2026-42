using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de jugadores: ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] puntajes = new int[cantidad];

        for (int i = 0; i < puntajes.Length; i++)
        {
            Console.Write($"Ingrese el puntaje de los jugadores {i + 1}: ");
            puntajes[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(puntajes); // Esta wachinada me pone las cosas de menor a mayor
        Array.Reverse(puntajes); // esta otra wachinada da vuelta la otra para que quede de mayor a menor PD: gracias yerik jugai mucho en el taller

        Console.WriteLine("Tabla de Posiciones de la liga mas watrina de la galaxia");
        for (int i = 0; i < puntajes.Length; i++)
        {
            Console.WriteLine($"{i + 1} puesto {puntajes[i]} puntos");
        }

        Console.WriteLine($"Primer Lugar (campeon de la secanuca cup): {puntajes[0]} puntos");
        Console.WriteLine($"Ultimo Lugar (jaja se fue a la B el wachin) {puntajes[puntajes.Length - 1]} puntos");

        Console.WriteLine("Presione cualquier tecla para salir");
        Console.ReadKey();
    }
}