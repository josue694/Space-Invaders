using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Representa una variante específica de enemigo en el juego.
    /// Hereda de la clase Clase_Enemigo y personaliza su imagen y color.
    /// </summary>
    public class Clase_Enemigo1 : Clase_Enemigo
    {
        /// <summary>
        /// Constructor que inicializa la posición y la imagen específica del enemigo.
        /// </summary>
        /// <param name="x">Coordenada inicial en X del enemigo.</param>
        /// <param name="y">Coordenada inicial en Y del enemigo.</param>
        public Clase_Enemigo1(int x, int y)
        {
            this.X = x; // Asigna la posición inicial en X.
            this.Y = y; // Asigna la posición inicial en Y.
            imagen = "}{"; // Asigna la imagen específica de este tipo de enemigo.
        }

        /// <summary>
        /// Devuelve la imagen que representa al enemigo.
        /// Sobreescribe el método de la clase base para personalizar su comportamiento.
        /// </summary>
        /// <returns>La imagen del enemigo como un string ("}{").</returns>
        protected override string DevolverImagen()
        {
            return imagen;
        }

        /// <summary>
        /// Devuelve el color del enemigo.
        /// Sobreescribe el método de la clase base para definir el color como azul.
        /// </summary>
        /// <returns>El color azul para este tipo de enemigo.</returns>
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Blue;
        }
    }
}
