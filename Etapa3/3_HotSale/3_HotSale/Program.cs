using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de productos vendidos: ");
        int cantidad = int.Parse(Console.ReadLine());

        double[] precios = new double[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el precio del producto {i + 1}: ");
            precios[i] = double.Parse(Console.ReadLine());
        }

        double precio_Mas_Caro = precios[0];
        double precio_Mas_Barato = precios[0];

        for (int i = 1; i < cantidad; i++)
        {
            if (precios[i] > precio_Mas_Caro)
            {
                precio_Mas_Caro = precios[i];
            }
            if (precios[i] < precio_Mas_Barato)
            {
                precio_Mas_Barato = precios[i];
            }
        }

        Console.WriteLine("Resultados del Hot Sale");
        Console.WriteLine($"El producto mas caro costo: {precio_Mas_Caro}");
        Console.WriteLine($"El producto mas económico costo: {precio_Mas_Barato}");

        Console.WriteLine("Presione cualquier tecla para salir");
        Console.ReadKey();
    }
}