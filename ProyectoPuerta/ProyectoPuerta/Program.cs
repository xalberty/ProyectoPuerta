using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuerta
{
    class Program
    {
		static Puerta door = new Puerta(100, 80);

		static void Main(string[] args)
        {
			
			int opcion = 0, cont = 0;

            do
            {
				if(cont > 0)
                {
                    Console.Write("\n\n\n\t\t\t\t\tEnter para limpiar la pantalla ");
					Console.ReadLine();
					Console.Clear();
                }
				cont++;

				opcion = Tools.Menu();

				switch(opcion)
                {
					case 1:
						door.Abrir();
						break;
					case 2:
						door.Cerrar();
						break;
					case 3:
						door.Mostrar();
						break;
					case 4:
						door.Color = Tools.EligeColor();
                        Console.WriteLine("\n\t\t\t\t\tEl color se ha cambiado");
						break;
					case 5:
						ModifyDoor();
						break;
					case 0:
                        Console.WriteLine("\n\n\t\t\t\t\tThx for using our app");
						break;

				}


            }while (opcion != 0);

            Console.Write("\n\n\n\n\t\t\t\t\tPress enter to skip ");
            Console.ReadLine();
		}

        static Puerta ModifyDoor() 
        {
            Console.WriteLine("\n\n\t----- Construyamos la puerta ------");
            int alto = Tools.CapturaEntero("\n\t¿Altura en cm?", 50, 250);
            int ancho = Tools.CapturaEntero("\n\t¿Anchura en cm?", 30, 250);
			ConsoleColor color = Tools.EligeColor();

			door.Alto = alto;
			door.Ancho = ancho;
			door.Color = color;

			return door;
        }

    }
}
