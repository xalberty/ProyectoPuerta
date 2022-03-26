using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuertaAvanzado
{
    class Puerta
    {
        int alto;
        int ancho;
        ConsoleColor color;
        bool estado = false; //** Yo he controlado el estado así pero, si quieres puedes hacerlo de otro modo 


        #region Propiedades
        public int Alto { get => alto; set => alto = value; }
        public int Ancho { get => ancho; set => ancho = value; }
        public ConsoleColor Color { get => color; set => color = value; }
        public bool Estado { get => estado; set => estado = value; }

        #endregion


        //---- Constructores -----

        public Puerta(int alto, int ancho)
        {
            this.alto = alto;
            this.ancho = ancho;
            color = ConsoleColor.White;
        }

        public Puerta(int alto, int ancho, ConsoleColor color)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.color = color;
        }


        //---- Métodos ----
        public void Abrir()
        {
            if (estado)
                Console.WriteLine("\n\n\t\t\t\t\tLa puerta ya estaba abierta!");
            else
            {
                Console.WriteLine("\n\n\t\t\t\t\tLa puera ahora está abierta!");
                estado = true;
            }
        }

        public void Cerrar()
        {
            if (!estado)
                Console.WriteLine("\n\n\t\t\t\t\tLa puerta ya estaba cerrada!");
            else
            {
                Console.WriteLine("\n\n\t\t\t\t\tLa puera ahora está cerrada!");
                estado = false;
            }
        }

        public void Mostrar()
        {
            if (!estado)
                Console.WriteLine("\n\n\t\t\t\t\tEstado: Cerrada");
            else
                Console.WriteLine("\t\t\t\t\tEstado: Abierta");
            Console.WriteLine("\t\t\t\t\tAlto: {0}", alto);
            Console.WriteLine("\t\t\t\t\tAncho: {0}", ancho);

            Console.Write("\t\t\t\t\tColor: ");
            Console.ForegroundColor = color;
            Console.Write(" ████████ ");
            Console.ResetColor();
            Console.WriteLine("◄ Este color");
            Console.ResetColor();
        }
    }
}
