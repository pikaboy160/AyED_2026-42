using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_nose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MateFran");
            Mate matefran = new Mate(10, 4, true, 70, "Quebracho");

            Console.WriteLine("Cantidad de Agua: " + matefran.getCantAgua());
            matefran.cebar();
            Console.WriteLine("Cantidad de Agua: " + matefran.getCantAgua());
            matefran.tomar(20);
            Console.WriteLine("Cantidad de Agua: " + matefran.getCantAgua());

            Mate matechampion = new Mate(10, 3, true, 40, "Aluminio");

            Console.WriteLine("");
            Console.WriteLine("Matechampion");
            Console.WriteLine("Cantidad de Agua: " + matechampion.getCantAgua());
            matechampion.cebar();
            Console.WriteLine("Cantidad de Agua: " + matechampion.getCantAgua());
            matechampion.tomar(20);
            Console.WriteLine("Cantidad de Agua: " + matechampion.getCantAgua());

            Mate matepiston = new Mate(5, 2.5, false, 15, "Aluminio");

            Console.WriteLine("");
            Console.WriteLine("Matepiston");
            Console.WriteLine("Cantidad de Agua: " + matepiston.getCantAgua());
            matepiston.cebar();
            Console.WriteLine("Cantidad de Agua: " + matepiston.getCantAgua());
            matepiston.tomar(5);
            Console.WriteLine("Cantidad de Agua: " + matepiston.getCantAgua());          

            Mate matepablito = new Mate(8, 3, false, 70, "Ceramica");

            Console.WriteLine("");
            Console.WriteLine("Matepablito");
            Console.WriteLine("Cantidad de Agua: " + matepablito.getCantAgua());
            matepablito.cebar();
            Console.WriteLine("Cantidad de Agua: " + matepablito.getCantAgua());
            matepablito.tomar(20);
            Console.WriteLine("Cantidad de Agua: " + matepablito.getCantAgua());


            Mate mateDeMarco = new Mate(12.5, 4, false, 75, "vidrio");

            Console.WriteLine("");
            Console.WriteLine("MateDeMarco");
            Console.WriteLine("Cantidad de Agua: " + mateDeMarco.getCantAgua());
            mateDeMarco.cebar();
            Console.WriteLine("Cantidad de Agua: " + mateDeMarco.getCantAgua());
            mateDeMarco.tomar(25);
            Console.WriteLine("Cantidad de Agua: " + mateDeMarco.getCantAgua());

            Mate mateEuropeo = new Mate(12.5, 4, false, 75, "vidrio");

            Console.WriteLine("");
            Console.WriteLine("MateEuropeo");
            Console.WriteLine("Cantidad de Agua: " + mateEuropeo.getCantAgua());
            mateEuropeo.cebar();
            Console.WriteLine("Cantidad de Agua: " + mateEuropeo.getCantAgua());
            mateEuropeo.tomar(35);
            Console.WriteLine("Cantidad de Agua: " + mateEuropeo.getCantAgua());
            Console.ReadKey();


            /*
            MateFran
             Altura = 10 cm
             TieneBombilla = True
             Capacidad = 70 ml
             Radio = 4 cm
             Material = "Quebracho"
             CantAgua = 0
             Tomar():void
             Cebar():void
--------------------------------------------------------------------
            MateChampion
             Altura = 10 cm 
             TieneBombilla = True
             Capacidad = 40 ml
             Radio = 3 cm
             Material = Aluminio
             CantAgua = 0
             Tomar():void
             Cebar():void
-------------------------------------------------------------------- 
            MatePiston
             Altura = 5 cm
             TieneBombilla = False
             Capacidad = 15 ml
             Radio = 2.5 cm
             Material = Aluminio
             CantAgua = 0
             Tomar():void
             Cebar():void
--------------------------------------------------------------------
            MatePablito
             Altura = 8 cm
             TieneBombilla = False
             Capacidad = 70 ml
             Radio = 3 cm
             Material = Ceramica
             CantAgua = 0
             Tomar():void
             Cebar():void
--------------------------------------------------------------------
            MateDeMarcos
             Altura = 12.5 cm
             TieneBombilla = False
             Capacidad = 75 ml
             Radio = 4 cm
             Material = Vidrio
             CantAgua = 0
             Tomar():void
             Cebar():void
--------------------------------------------------------------------
            MateEuropeo
             Altura = 12.5 cm
             TieneBombilla = False
             Capacidad = 75 ml
             Radio = 4 cm
             Material = Aluminio
             CantAgua = 0
             Tomar():void
             Cebar():void
             */
        }
    }
    class Mate 
    {
             private double Altura; 
             private bool TieneBombilla;
             private int Capacidad ;
             private double Radio;
             private string Material;
             private int CantAgua = 0;

        public Mate(double Altura, double Radio, bool TieneBombilla, int Capacidad, string Material)
        {
            this.Altura = Altura;
            this.Radio = Radio;
            this.TieneBombilla = TieneBombilla;
            this.Capacidad = Capacidad;
            this.Material = Material;     
        }

        public void cebar()
        {
            CantAgua = Capacidad;
        }

        public void tomar(int tomar)
        {

            CantAgua = CantAgua - tomar;
        }

       public int getCantAgua()
        {
            return CantAgua;
        }
    }

}
