using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Representa una variante específica de enemigo en el juego, con una imagen y color únicos.
    /// Hereda de la clase Clase_Enemigo.
    /// </summary>
    internal class Clase_Enemigo2 : Clase_Enemigo
    {
        /// <summary>
        /// Constructor que inicializa las coordenadas y la imagen específica de este enemigo.
        /// </summary>
        /// <param name="x">Coordenada inicial en X del enemigo.</param>
        /// <param name="y">Coordenada inicial en Y del enemigo.</param>
        public Clase_Enemigo2(int x, int y)
        {
            this.X = x; // Asigna la posición inicial en X.
            this.Y = y; // Asigna la posición inicial en Y.
            imagen = ")("; // Asigna la imagen específica de este tipo de enemigo.
        }

        /// <summary>
        /// Devuelve la imagen que representa al enemigo.
        /// Este método sobrescribe la implementación de la clase base.
        /// </summary>
        /// <returns>La imagen del enemigo como un string (")(").</returns>
        protected override string DevolverImagen()
        {
            return imagen;
        }

        /// <summary>
        /// Devuelve el color del enemigo.
        /// Este método sobrescribe la implementación de la clase base.
        /// </summary>
        /// <returns>El color verde para este tipo de enemigo.</returns>
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Green;
        }
    }
}
