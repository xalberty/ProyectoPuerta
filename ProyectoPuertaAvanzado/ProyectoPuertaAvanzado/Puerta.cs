using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuertaAvanzado
{
    class Puerta
    {
        string nombre;
        int alto;
        int ancho;
        ConsoleColor color;
        bool estado = false; // False -> Closed| True -> Open
        bool situacion = true; // False -> Unmounted| True -> Mounted


        #region Propiedades

        public string Nombre { get => nombre; set => nombre = value; }
        public int Alto { get => alto; set => alto = value; }
        public int Ancho { get => ancho; set => ancho = value; }
        public ConsoleColor Color { get => color; set => color = value; }
        public bool Estado { get => estado; set => estado = value; }

        #endregion


        public Puerta(string nombre, int alto, int ancho)
        {
            this.nombre = nombre;
            this.alto = alto;
            this.ancho = ancho;
            color = ConsoleColor.White;
        }

        public Puerta(string nombre, int alto, int ancho, ConsoleColor color)
        {
            this.nombre = nombre;
            this.alto = alto;
            this.ancho = ancho;
            this.color = color;
        }


        public void Abrir()
        {
            if (!situacion)
            {
                Console.WriteLine("\n\n\t\t\t\t\tError al abrir la puerta");
                Console.WriteLine("\t\t\t   Para ejecutar esta ación primero has de montar {0}", nombre);
            }
            else
            {       
                if (estado)
                    Console.WriteLine("\n\n\t\t\t\t\t{0} ya estaba abierta!",nombre);
                else
                {
                    Console.WriteLine("\n\n\t\t\t\t\t{0} ahora está abierta!", nombre);
                    estado = true;
                }
            }
        }

        public void Cerrar()
        {
            if (!situacion)
            {
                Console.WriteLine("\n\n\t\t\t\t\tError al abrir la puerta");
                Console.WriteLine("\t\t\t   Para ejecutar esta ación primero has de montar la puerta {0}", nombre);
            }
            else
            {
                if (!estado)
                    Console.WriteLine("\n\n\t\t\t\t\t{0} ya estaba cerrada!", nombre);
                else
                {
                    Console.WriteLine("\n\n\t\t\t\t\t{0} ahora está cerrada!", nombre);
                    estado = false;
                }
            }
        }

        public void Montar()
        {
            if (situacion)
                Console.WriteLine("\n\n\t\t\t\t\t{0} ya se encuentra montada!", nombre);
            else
            {
                Console.WriteLine("\n\n\t\t\t\t\tHas montado {0}!", nombre);
                situacion = true;
            }
                
        }

        public void Desmontar()
        {
            if(!situacion)
                Console.WriteLine("\n\n\t\t\t\t\t{0} ya se encuentra desmontada!", nombre);
            else
            {
                Console.WriteLine("\n\n\t\t\t\t\tHas desmontado {0}!", nombre);
                situacion= false;
            }
                
        }

        public void Mostrar()
        {
            Console.WriteLine("\n\n\t\t\t\t\tNombre: {0}", nombre);

            if (!estado)
                Console.WriteLine("\t\t\t\t\tEstado: Cerrada");
            else
                Console.WriteLine("\t\t\t\t\tEstado: Abierta");
            if (!situacion)
                Console.WriteLine("\n\n\t\t\t\t\tSituación: Desmontada");
            else
                Console.WriteLine("\t\t\t\t\tSituación: Montada");

            Console.WriteLine("\t\t\t\t\tAlto: {0}", alto);
            Console.WriteLine("\t\t\t\t\tAncho: {0}", ancho);

            Console.Write("\t\t\t\t\tColor: ");
            Console.ForegroundColor = color;
            Console.Write(" ████████ ");
            Console.ResetColor();
            Console.WriteLine("◄ Este color");
            Console.ResetColor();
        }

        //public override string ToString()
        //{
        //    Console.ForegroundColor = color;

        //    return String.Format
        //    (
        //        "{0}{1}{2}{3}",

        //        "\n\n\tEstado: " + estado,
        //        "\n\tNombre: " + nombre,
        //        "\n\tAlto: " + alto,
        //        "\tColor: ████████ " + color + " ◄ Este color"
        //    );

        //}
    }
}
