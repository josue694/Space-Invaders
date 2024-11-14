using System;

namespace ConsoleApp1
{
    internal class Clase_Ovni : Clase_Sprite
    {
        Random generador;
        int aleatorio;
        bool activo;

        public Clase_Ovni()
        {
            X = 0;
            Y = 6;
            activo = false;
            generador = new Random();
            imagen = "(||)";
        }

        public bool Activo { get => activo; set => activo = value; }

        protected override string DevolverImagen()
        {
            if (activo) return "(||)";
            else return "";
        }

        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Yellow;
        }

        public void Mover()
        {
            if (!activo)
            {
                aleatorio = generador.Next(1, 61);
                if (aleatorio == 2)
                {
                    activo = true;
                    X = 0; 
                }
            }
            else
            {
                X++;
                if (X >= 76) activo = false;
                
            }
        }

        
        protected override int DevolverLongigud()
        {
            return 4;
        }

    }
}
