using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Inicio;

namespace Tabla
{
    public class Pizarron
    {
        public static void MainP(string[] args)
        {
            
            Pizarra();
        }

        public static void Pizarra()
        {
            Console.Clear();
            int width = 100;
            int height = 20;

            for (int i = 0; i < height; i++)
            {
                Console.CursorLeft = width + 1;
                Console.Write("||");
                Console.CursorTop++;
                Console.CursorLeft = Console.CursorLeft - 2;
                Console.Write("||");
            }
            Console.CursorLeft = Console.CursorLeft - width - 2;

            for (int i = 0; i < width - 49; i++)
            {
                Console.Write("||");
            }

            Console.CursorTop = 25;
            Console.CursorLeft = 1;

            Console.WriteLine("Bienvenido!!");

            Console.WriteLine("para comenzar a dibujar debe elegir un color: ");

            Console.WriteLine("Q = blanco, W = rojo , E = azul,  R = verde, BackSpace = borrar y Escape = salir");

            Console.WriteLine("puede utilizar las flechitas para desplasarse por la pizarra");
            
            Console.CursorLeft = 1;
            Console.CursorTop = 1;

            //mover el crusor por la pantalla
            moverCrusor();
        }

        static void moverCrusor()
        {

            char c = ' ';

            bool fin = false;

            do
            {
                ConsoleKeyInfo k = Console.ReadKey(true);
                switch (k.Key)
                {
                    case ConsoleKey.Q:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        c = '█';
                        break;
                    case ConsoleKey.W:
                        Console.ForegroundColor = ConsoleColor.Red;
                        c = '█';
                        break;
                    case ConsoleKey.E:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        c = '█';
                        break;
                    case ConsoleKey.R:
                        Console.ForegroundColor = ConsoleColor.Green;
                        c = '█';
                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop < 19)
                        {
                            Console.CursorTop++;
                            Console.Write(c);
                            Console.CursorLeft--;
                        }
                        break;

                    case ConsoleKey.UpArrow:

                        if (Console.CursorTop > 0)
                        {
                            Console.CursorTop--;
                            Console.Write(c);
                            Console.CursorLeft--;
                        }
                        break;

                    case ConsoleKey.LeftArrow:

                        if (Console.CursorLeft > 0)
                        {
                            Console.CursorLeft--;
                            Console.Write(c);
                            Console.CursorLeft--;
                        }
                        break;

                    case ConsoleKey.RightArrow:

                        if (Console.CursorLeft < 100)
                        {
                            Console.Write(c);
                        }
                        break;
                    case ConsoleKey.Backspace:
                        c = ' ';
                        break;
                    case ConsoleKey.Escape:
                        Principal.Inicio();
                        break;
                    default:
                        fin = true;
                        break;
                }
            } while (!fin);
        }
    }
}