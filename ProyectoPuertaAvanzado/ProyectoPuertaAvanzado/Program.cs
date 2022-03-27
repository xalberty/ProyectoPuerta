using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoPuertaAvanzado
{
    class Program
    {
        static Puerta baseDoor1 = new Puerta("PB1",100, 80);
        static Puerta baseDoor2 = new Puerta("PB2", 80, 120);
        static Puerta auxDoor;
        static List<Puerta> myList = new List<Puerta>();
        static int cont1 = 0;

        static void Main(string[] args)
        {
            myList.Add(baseDoor1);
            myList.Add(baseDoor2);

            

            int opcion = 0, cont = 0;

            do
            {
                if (cont > 0)
                {
                    Console.Write("\n\n\n\t\t\t\t\tEnter para limpiar la pantalla ");
                    Console.ReadLine();
                    Console.Clear();
                }
                cont++;

                opcion = Tools.Menu();

                int k = 0;
                switch (opcion)
                {
                    case 1:
                        int w = Tools.CapturaNumPulsado("\n\t\t\t\t\t1) Abrir solo una puerta \n\t\t\t\t\t2) Abrir todas las puertas \n\n\t\t\t\t\tEliga una opción: ", 1, 2);
                        if (w == 1)
                        {
                            k = SeleccionarPuerta(myList, "Introduzca el indice de la puerta a abrir: ");
                            myList[k-1].Abrir();
                        }
                        if (w == 2)
                        {
                            foreach (var item in myList)
                            {
                                item.Abrir();
                            }
                        }
                        break;
                    case 2:
                        int y = Tools.CapturaNumPulsado("\n\t\t\t\t\t1) Cerrar solo una puerta \n\t\t\t\t\t2) Cerrar todas las puertas \n\n\t\t\t\t\tEliga una opción: ", 1, 2);
                        if (y == 1)
                        {
                            k = SeleccionarPuerta(myList, "Introduzca el indice de la puerta a cerra: ");
                            myList[k-1].Cerrar();
                        }
                        if (y == 2)
                        {
                            foreach (var item in myList)
                            {
                                item.Cerrar();
                            }
                        }
                        break;
                    case 3:
                        int o = Tools.CapturaNumPulsado("\n\t\t\t\t\t1) Montar solo una puerta \n\t\t\t\t\t2) Montar todas las puertas \n\n\t\t\t\t\tEliga una opción: ", 1, 2);
                        if (o == 1)
                        {
                            k = SeleccionarPuerta(myList, "Introduzca el indice de la puerta a montar: ");
                            myList[k-1].Montar();
                        }
                        if (o == 2)
                        {
                            foreach (var item in myList)
                            {
                                item.Montar();
                            }
                        }
                        break;
                    case 4:
                        int p = Tools.CapturaNumPulsado("\n\t\t\t\t\t1) Desmontar solo una puerta \n\t\t\t\t\t2) Desmontar todas las puertas \n\n\t\t\t\t\tEliga una opción: ", 1, 2);
                        if (p == 1)
                        {
                            k = SeleccionarPuerta(myList, "Introduzca el indice de la puerta a desmontar: ");
                            myList[k-1].Desmontar();
                        }
                        if (p == 2)
                        {
                            foreach (var item in myList)
                            {
                                item.Desmontar();
                            }
                        }
                        break;
                    case 5:
                        int c = Tools.CapturaNumPulsado("\n\t\t\t\t\t1) Mostrar solo una puerta \n\t\t\t\t\t2) Mostrar todas las puertas \n\n\t\t\t\t\tEliga una opción: ", 1, 2);
                        if (c == 1)
                        {
                            k = SeleccionarPuerta(myList, "Introduzca el indice de la puerta a mostrar: ");
                            myList[k-1].Mostrar();
                        }
                        if (c == 2)
                        {
                            foreach (var item in myList)
                            {
                                item.Mostrar();
                            }
                        }
                        break;
                    case 6:
                        k = SeleccionarPuerta(myList, "Introduzca el indice de la puerta a pintar: ");
                        myList[k-1].Color = EligeColor();
                        Console.WriteLine("\n\t\t\t\t\tEl color se ha cambiado");
                        break;
                    case 7:
                        ModifyDoor();
                        break;
                    case 8:
                        cont1++;
                        CreateDoor(cont);
                        break;
                    case 9:
                        EraseElement(myList);
                        break;
                    case 0:
                        Console.WriteLine("\n\n\n\t\t\t\t\tThx for using our app");
                        break;

                }


            } while (opcion != 0);

            Thread.Sleep(2000);

        }

        static Puerta ModifyDoor()
        {
            int a = SeleccionarPuerta(myList, "Introduzca el nombre de la puerta a modificar: ");

            Console.WriteLine("\n\n\t\t\t\t     --- Modifiquemos la puerta ---");
            int alto = Tools.CapturaEntero("\n\t\t\t\t\t¿Altura en cm?", 50, 250);
            int ancho = Tools.CapturaEntero("\n\t\t\t\t\t¿Anchura en cm?", 30, 250);
            ConsoleColor color = EligeColor();

            myList[a].Alto = alto;
            myList[a].Ancho = ancho;
            myList[a].Color = color;

            return auxDoor;
        }

        static Puerta CreateDoor(int cont)
        {
            

            Console.WriteLine("\n\n\t\t\t\t     --- Construyamos la puerta ---");

            string name= "P" + Convert.ToString(cont);
            Console.WriteLine("\n\t\t\t\t\tEsta construyendo la puerta {0}", name);
            int alto = Tools.CapturaEntero("\n\t\t\t\t\t¿Altura en cm?", 50, 250);
            int ancho = Tools.CapturaEntero("\n\t\t\t\t\t¿Anchura en cm?", 30, 250);
            ConsoleColor color = EligeColor();

            myList.Add(new Puerta(name, alto, ancho, color));

            return auxDoor;
        }

        static void EraseElement(List<Puerta> listaPuertas)
        {
            Console.WriteLine();

            for (int i = 0; i < listaPuertas.Count; i++)
            {
                Console.WriteLine("\t\t\t\t\t{0}) {1}", i+1, listaPuertas[i].Nombre);
            }

            int a = Tools.CapturaNumPulsado("Posicion de la puerta ha eliminar: ", 1, listaPuertas.Count+1);
            listaPuertas.RemoveAt(a-1);
            Console.WriteLine("\n\n\t\t\t\t\tPuerta elimina con éxito!");


        }

        static int SeleccionarPuerta(List<Puerta> listaPuertas, string texto)
        {
            Console.WriteLine();

            for (int i = 0; i < listaPuertas.Count; i++)
            {
                Console.WriteLine("\t\t\t\t\t{0}) {1}", i + 1, listaPuertas[i].Nombre);
            }

            int a = Tools.CapturaNumPulsado(texto, 1, listaPuertas.Count);
    
            return a;

        }

        //static Puerta SeleccionarPuerta(List<Puerta> listaPuertas, string texto)
        //{
        //    string nombre = String.Empty;
        //    bool nombreOk = false;
        //    Puerta puerta = new Puerta("puerta", 100, 80, ConsoleColor.White);

        //    Console.WriteLine("\n");

        //    for (int i = 0; i < listaPuertas.Count; i++)
        //    {
        //        Console.WriteLine("\t\t\t\t\t{0}) {1}", i + 1, listaPuertas[i].Nombre);
        //    }

        //    do
        //    {
        //        nombreOk = false;
        //        Console.Write("\n\n\t\t\t\t {0}", texto);
        //        nombre = Console.ReadLine();

        //        for (int i = 0; i < listaPuertas.Count; i++)
        //        {
        //            if (listaPuertas[i].Nombre == nombre)
        //            {
        //                nombreOk = true;
        //                puerta = listaPuertas[i];
        //            }
        //            else
        //                nombreOk = false;

        //        }

        //        if(!nombreOk)
        //            Console.WriteLine("\n\n\t\t\t\tError: Ningún nombre de la lista coincide con el introducido");

        //    } while (!nombreOk);

        //    return puerta;
        //}

        public static ConsoleColor EligeColor()
        {

            ConsoleColor[] vColors = { ConsoleColor.White, ConsoleColor.DarkGray, ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Green };

            Console.WriteLine("\n");

            for (int i = 0; i < vColors.Length; i++)
            {
                Console.Write("\t\t\t\t\t {0})", i + 1);
                Console.ForegroundColor = vColors[i];
                Console.WriteLine(" ████████ ");
                Console.ResetColor();
            }

            int color = Tools.CapturaEntero("\n\t\t\t\t\tElige un color", 1, 6);

            return vColors[color - 1];
        }

    }
}
