using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            int promedio_examenes = 0;
            int tps_aprobados = 0; 
            bool aprobado = false;

            Console.Write("Ingrese la cantidad de Exámenes que tendran: ");
            int cantExamenes = int.Parse(Console.ReadLine());
            int[] examenes = new int[cantExamenes];

            Console.Write("Ingrese la cantidad de TPs que tendran: ");
            int cantTPs = int.Parse(Console.ReadLine());
            int[] tps = new int[cantTPs];

            for (int i = 0; i < tps.Length; i++)
            {
                Console.Write($"Ingrese la nota de su TP {i + 1}: ");
                int nota = int.Parse(Console.ReadLine());

                while (nota > 10 || nota < 0)
                {
                    Console.Write($"Nota invalida Reingrese nota del TP {i + 1}: ");
                    nota = int.Parse(Console.ReadLine());
                }
                tps[i] = nota;
            }
        
            for (int i = 0; i < examenes.Length; i++)
            {
                Console.Write($"Ingrese la nota de su examen {i + 1}: ");
                int nota = int.Parse(Console.ReadLine());

                while (nota > 10 || nota < 0)
                {
                    Console.Write($"Nota invalida Reingrese nota del examen {i + 1}: ");
                    nota = int.Parse(Console.ReadLine());
                }
                examenes[i] = nota; 
            }

            for (int i = 0; i < examenes.Length; i++)
            {
                promedio_examenes += examenes[i];
            }

            for (int i = 0; i < tps.Length; i++)
            {
                if (tps[i] >= 6)
                {
                    tps_aprobados++;
                }
            }

            if (examenes.Length > 0)
            {
                double promedioFinalExamenes = (double)promedio_examenes / examenes.Length;

                if (tps_aprobados >= (tps.Length * 0.75) && promedioFinalExamenes >= 6)
                {
                    aprobado = true;
                }

                if (aprobado == true)
                {
                    Console.WriteLine($"usted a aprobado con un promedio de {promedioFinalExamenes} en los examenes");
                    Console.WriteLine($"y con un total de {tps_aprobados} aprobados de {tps.Length} TPs disponibles");
                }
                else
                {
                    Console.WriteLine($"usted a desaprobado con un promedio de {promedioFinalExamenes} en los examenes");
                    Console.WriteLine($"y con un total de {tps_aprobados} aprobados de {tps.Length} TPs disponibles");
                }
            }      
            Console.ReadKey();
        }
    }
}
