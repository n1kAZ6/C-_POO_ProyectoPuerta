using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuerta
{
    class Util
    {
		// Faltan bastantes cláusulas

		public static int CapturaEntero(string mensaje, int min, int max)
        {
            int valor = 0;
            bool numCorrecto;

            do
            {
                Console.Write("\n\t{0} [{1}..{2}]: ",mensaje, min, max);
                numCorrecto = Int32.TryParse(Console.ReadLine(),out valor);

                if(!numCorrecto)
                    Console.WriteLine("\n\t** [ERROR] No ha introducido un número entero. **");
                else if(valor < min || valor > max)
                {
                    numCorrecto=false;
                    Console.WriteLine("\n\t** [ERROR] El número introducido no se encuentra entre {0} y {1}. **",min,max);
                }


            } while (!numCorrecto);
			
            return valor;
        }

        public static int CapturaNumPulsado(string mensaje, int min, int max)
        {
            int valor = 0;

            do
            {
                Console.Write("{0} [{1}..{2}]: ", mensaje, min, max);
                valor = Console.ReadKey().KeyChar - '0';

                if (valor < min || valor > max) 
                {
                    Console.Beep();
                    Console.Write(" ** NO VALIDO. ({0} a {1})\n",min,max);
                }

            } while (valor < min || valor > max);

            return valor;
        }

        public static int Menu()
        {
            Console.Clear();
			Console.WriteLine("\n\n\n\n");
			Console.WriteLine("\t\t\t╔═════════════════════╗");
            Console.WriteLine("\t\t\t║   MENÚ de PUERTA    ║");
            Console.WriteLine("\t\t\t╠═════════════════════╣");
            Console.WriteLine("\t\t\t║     1) Abrir        ║");
            Console.WriteLine("\t\t\t║                     ║");
            Console.WriteLine("\t\t\t║     2) Cerrar       ║");
			Console.WriteLine("\t\t\t║                     ║");
			Console.WriteLine("\t\t\t║     3) Mostrar      ║");
			Console.WriteLine("\t\t\t║                     ║");
            Console.WriteLine("\t\t\t║     4) Pintar       ║");
			Console.WriteLine("\t\t\t║                     ║");
			Console.WriteLine("\t\t\t║     5) Fabricar     ║");
			Console.WriteLine("\t\t\t║_____________________║");
            Console.WriteLine("\t\t\t║                     ║");
            Console.WriteLine("\t\t\t║     0) Salir        ║");
            Console.WriteLine("\t\t\t╚═════════════════════╝");

            return CapturaNumPulsado("\t\t\tPulse su opción", 0, 5);
        }

		public static ConsoleColor EligeColor()
        {
            Console.Clear();
            Console.WriteLine("\n\tElige un color");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\t0: ████████ ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t1: ████████ ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t2: ████████ ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t3: ████████ ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t4: ████████ ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t5: ████████ ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t6: ████████ ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t7: ████████ ");
            Console.ResetColor();

            int indice = CapturaNumPulsado("\t¿Color?", 0, 7);

            switch (indice) 
            {
                case 0: return ConsoleColor.Gray;
                case 1: return ConsoleColor.Blue;
                case 2: return ConsoleColor.Green;
                case 3: return ConsoleColor.Cyan;
                case 4: return ConsoleColor.Red;
                case 5: return ConsoleColor.Magenta;
                case 6: return ConsoleColor.Yellow;
                case 7: return ConsoleColor.White;

            }
            return ConsoleColor.Black;
        }
        public static void Pausa() 
        {
            Console.WriteLine("\nPulse UNA TECLA para VOLVER AL MENÚ");
            Console.ReadKey(true);
        }

    }
}
