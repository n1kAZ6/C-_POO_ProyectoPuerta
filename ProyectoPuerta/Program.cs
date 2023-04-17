using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuerta
{
    class Program
    {
        static void Main(string[] args)
        {
			Puerta p1 = new Puerta(100, 80);
			int opcion;
			do
			{
				opcion = Util.Menu();
				switch (opcion) 
				{
					case 1:
						p1.Abrir();
						break;

					case 2:
						p1.Cerrar();
						break;

                    case 3:
						p1.Mostrar();
                        break;

                    case 4:
						p1.Color=Util.EligeColor();
						p1.Mostrar();
                        break;

                    case 5:
						p1=FabricarPuerta();
						p1.Mostrar();
                        break;

					default:
						break;
                }


            } while (opcion != 0);


            Console.WriteLine("\n\nPulsa una tecla para salir...");
			Console.ReadKey(true);

        }
		public static Puerta FabricarPuerta() // le falta una cláusula
		{
			Console.Clear();
			Console.WriteLine("\n\n\t----- Construyamos la puerta ------");
			int alto = Util.CapturaEntero("\n\t¿Altura en cm?", 50, 250);
			int ancho = Util.CapturaEntero("\n\t¿Anchura en cm?", 30, 250);
			ConsoleColor color = Util.EligeColor();

			return new Puerta(alto, ancho, color);
		}

	}
}
