using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Clase base abstracta para representar un sprite (elemento visual en la pantalla)
    public abstract class Clase_Sprite
    {
        // Imagen que representa al sprite (por ejemplo, la forma de la nave, el disparo, etc.)
        protected string imagen;

        // Coordenadas (X, Y) del sprite en la consola
        private int x;
        private int y;

        // Propiedades para acceder y modificar las coordenadas X y Y del sprite
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        // Método para dibujar el sprite en la consola
        public void Dibujar()
        {
            // Establece la posición del cursor en las coordenadas X e Y
            Console.SetCursorPosition(X, Y);

            // Establece el color del sprite según lo devuelto por el método abstracto
            Console.ForegroundColor = DevolverColor();

            // Dibuja la imagen del sprite
            Console.Write(DevolverImagen());

            // Hace que el cursor no sea visible
            Console.CursorVisible = false;
        }

        // Métodos abstractos que deben ser implementados por las clases derivadas
        // Estos métodos definen cómo se debe representar el sprite en la consola
        protected abstract string DevolverImagen();
        protected abstract ConsoleColor DevolverColor();
        protected abstract int DevolverLongigud();

        // Método para verificar si este sprite colisiona con otro sprite
        public bool ColisionaCon(Clase_Sprite sprite)
        {
            // Si las coordenadas Y de ambos sprites no coinciden, no hay colisión
            if (this.Y != sprite.Y)
                return false;
            else
            {
                // Si las coordenadas Y coinciden, revisamos si las coordenadas X se superponen
                for (int i = 0; i < this.DevolverLongigud(); i++)
                {
                    for (int j = 0; j < sprite.DevolverLongigud(); j++)
                    {
                        // Si alguna parte de los dos sprites se superpone en las coordenadas X, hay colisión
                        if ((this.X + i) == (sprite.X + j))
                            return true;
                    }
                }
            }
            // Si no hay superposición en las coordenadas X, no hay colisión
            return false;
        }
    }
}
