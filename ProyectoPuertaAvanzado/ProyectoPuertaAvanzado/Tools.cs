using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuertaAvanzado
{
    class Tools
    {

        public static int CapturaEntero(string texto, int min, int max)
        {
            int valor = 0;
            bool esCorrecto;
            do
            {
                Console.Write("{0} [{1}..{2}]: ", texto, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
                if (esCorrecto)
                {

                    if (valor < min || valor > max)
                    {
                        Console.WriteLine("\n\t\t\t\t\t*** Error: valor fuera de rango ***");
                        esCorrecto = false;
                    }
                }
                else
                    Console.WriteLine("\n\t\t\t\t\t*** Error: No se ha introducido un número entero ***");
            } while (!esCorrecto);
            return valor;
        }

        public static int CapturaNumPulsado(string mensaje, int min, int max)
        {
            int opcion = 0;

            Console.Write("\n\t\t\t\t\t{0}",mensaje);
            
            opcion = Console.ReadKey(true).KeyChar - '0';
            
            while (opcion < min|| opcion > max)
            {
                Console.WriteLine("\n\n\t\t\t\t\tERROR");
                Console.Write("\n\t\t\t\t\tIntroduce una opción: ");
                opcion = Console.ReadKey().KeyChar - '0';
            }

            return opcion;
        }

        public static int Menu()
        {

            Console.WriteLine("\n\n");
			Console.WriteLine("\t\t\t\t\t╔═════════════════════╗");
            Console.WriteLine("\t\t\t\t\t║   MENÚ de PUERTA    ║");
            Console.WriteLine("\t\t\t\t\t╠═════════════════════╣");
            Console.WriteLine("\t\t\t\t\t║     1) Abrir        ║");
            Console.WriteLine("\t\t\t\t\t║                     ║");
            Console.WriteLine("\t\t\t\t\t║     2) Cerrar       ║");
			Console.WriteLine("\t\t\t\t\t║                     ║");
            Console.WriteLine("\t\t\t\t\t║     3) Montar       ║");
            Console.WriteLine("\t\t\t\t\t║                     ║");
            Console.WriteLine("\t\t\t\t\t║     4) Desmontar    ║");
            Console.WriteLine("\t\t\t\t\t║                     ║");
            Console.WriteLine("\t\t\t\t\t║     5) Mostrar      ║");
			Console.WriteLine("\t\t\t\t\t║                     ║");
            Console.WriteLine("\t\t\t\t\t║     6) Pintar       ║");
			Console.WriteLine("\t\t\t\t\t║                     ║");
			Console.WriteLine("\t\t\t\t\t║     7) Modificar    ║");
            Console.WriteLine("\t\t\t\t\t║                     ║");
            Console.WriteLine("\t\t\t\t\t║     8) Crear        ║");
            Console.WriteLine("\t\t\t\t\t║                     ║");
            Console.WriteLine("\t\t\t\t\t║     9) Eliminar     ║");
            Console.WriteLine("\t\t\t\t\t║_____________________║");
            Console.WriteLine("\t\t\t\t\t║                     ║");
            Console.WriteLine("\t\t\t\t\t║     0) Salir        ║");
            Console.WriteLine("\t\t\t\t\t╚═════════════════════╝");


            return CapturaNumPulsado("Pulse su opción: ", 0, 9);
            
        }

   

    }
}
