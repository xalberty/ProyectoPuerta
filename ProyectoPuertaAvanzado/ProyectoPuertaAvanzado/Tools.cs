using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuertaAvanzado
{
    class Tools
    {
        // Faltan bastantes cláusulas

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

        static int CapturaNumPulsado(string mensaje, int min, int max)
        {
            int opcion = 0;

            Console.Write("\n\t\t\t\t\tIntroduce una opción: ");
            // guardamos el valor numérico de la tecla pulsada
            opcion = Console.ReadKey().KeyChar - '0';
            // Comprobamos que se ha pulsado una opción correcta
            while (opcion < 0 || opcion > 5)
            {
                Console.WriteLine("\n\n\t\t\t\t\tERROR");
                Console.Write("\n\t\t\t\t\tIntroduce una opción: ");
                opcion = Console.ReadKey().KeyChar - '0';
            }

            return opcion;
        }

        public static int Menu()
        {

            Console.WriteLine("\n\n\n");
			Console.WriteLine("\t\t\t\t\t╔═════════════════════╗");
            Console.WriteLine("\t\t\t\t\t║   MENÚ de PUERTA    ║");
            Console.WriteLine("\t\t\t\t\t╠═════════════════════╣");
            Console.WriteLine("\t\t\t\t\t║     1) Abrir        ║");
            Console.WriteLine("\t\t\t\t\t║                     ║");
            Console.WriteLine("\t\t\t\t\t║     2) Cerrar       ║");
			Console.WriteLine("\t\t\t\t\t║                     ║");
			Console.WriteLine("\t\t\t\t\t║     3) Mostrar      ║");
			Console.WriteLine("\t\t\t\t\t║                     ║");
            Console.WriteLine("\t\t\t\t\t║     4) Pintar       ║");
			Console.WriteLine("\t\t\t\t\t║                     ║");
			Console.WriteLine("\t\t\t\t\t║     5) Fabricar     ║");
			Console.WriteLine("\t\t\t\t\t║_____________________║");
            Console.WriteLine("\t\t\t\t\t║                     ║");
            Console.WriteLine("\t\t\t\t\t║     0) Salir        ║");
            Console.WriteLine("\t\t\t\t\t╚═════════════════════╝");


            return CapturaNumPulsado("Pulse su opción", 0, 5);
            
        }

        public static ConsoleColor EligeColor()
        {
            ConsoleColor[] vColors = { ConsoleColor.White,  ConsoleColor.DarkGray, ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Green };

            Console.WriteLine("\n");

            for (int i = 0; i < vColors.Length; i++)
            {
                Console.Write("\t\t\t\t\t {0})", i+1);
                Console.ForegroundColor = vColors[i];
                Console.WriteLine(" ████████ ");
                Console.ResetColor();
            }

            int color = CapturaEntero("\n\t\t\t\t\tElige un color", 1, 6);

            return vColors[color-1];
        }

    }
}
