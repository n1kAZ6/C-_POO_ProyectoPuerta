using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuerta
{
    class Puerta
    {
        int alto, ancho;
        ConsoleColor color;
        bool abierta = false; //** Yo he controlado el estado así pero, si quieres puedes hacerlo de otro modo 

        #region Propiedades


        #endregion
        public int Alto { get => alto; set => alto = value; }
        public int Ancho { get => ancho; set => ancho = value; }
        public ConsoleColor Color { get => color; set => color = value; }
        public bool Abierta { get => abierta; set => abierta = value; }

        //---- Constructores -----
        public Puerta(int alto, int ancho, ConsoleColor color)
        {
            this.Alto = alto;
            this.Ancho = ancho;
            this.Color = color;
        }
        public Puerta(int alto, int ancho) 
        {
            this.Alto= alto;
            this.Ancho= ancho;
            this.Color = ConsoleColor.White;
        }


        //---- Métodos ----
        public void Abrir()
        {
            Console.Clear();
            if(!Abierta)
                Abierta = true;
            Console.WriteLine("\n\tPuerta abierta!");
            Util.Pausa();
        }


        public void Cerrar()
        {
            Console.Clear();
            if(Abierta)
                Abierta = false;
            Console.WriteLine("\n\tPuerta cerrada!");
            Util.Pausa();
        }

        public void Mostrar() 
        {
            Console.Clear();
            Console.ForegroundColor = Color;
			Console.WriteLine("\n\n\tEstado: {0}",Abierta ? "Abierta" : "Cerrada" );
			Console.WriteLine("\n\tAlto: {0}", Alto);
			Console.WriteLine("\tAncho: {0}",Ancho); 
            
            Console.Write("\tColor: ████████ ",Color);
            Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("◄ Este color");

            Util.Pausa();
		}
    }
}
