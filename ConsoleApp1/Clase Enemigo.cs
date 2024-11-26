using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Representa un enemigo en el juego. Hereda de Clase_Sprite para manejar propiedades comunes como posición, imagen y color.
    /// </summary>
    public class Clase_Enemigo : Clase_Sprite
    {
        // Indica si el enemigo está activo (puede interactuar con otros objetos o ser dibujado).
        private bool activo;

        /// <summary>
        /// Constructor sin parámetros. Inicializa un enemigo en una posición predeterminada.
        /// </summary>
        public Clase_Enemigo()
        {
            X = 40; // Posición inicial predeterminada en X.
            Y = 10; // Posición inicial predeterminada en Y.
            imagen = "]["; // Imagen que representa al enemigo.
            activo = true; // El enemigo comienza activo.
        }

        /// <summary>
        /// Constructor con parámetros. Permite crear un enemigo en una posición específica.
        /// </summary>
        /// <param name="x">Posición inicial en X del enemigo.</param>
        /// <param name="y">Posición inicial en Y del enemigo.</param>
        public Clase_Enemigo(int x, int y)
        {
            this.X = x; // Asigna la posición inicial en X.
            this.Y = y; // Asigna la posición inicial en Y.
            imagen = "]["; // Imagen que representa al enemigo.
            activo = true; // El enemigo comienza activo.
        }

        /// <summary>
        /// Propiedad para acceder o modificar el estado de actividad del enemigo.
        /// </summary>
        public bool Activo { get => activo; set => activo = value; }

        /// <summary>
        /// Devuelve el color del enemigo. Este método sobreescribe el comportamiento de la clase base.
        /// </summary>
        /// <returns>El color amarillo para el enemigo.</returns>
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Yellow;
        }

        /// <summary>
        /// Devuelve la imagen que representa al enemigo en el juego.
        /// Este método sobreescribe el comportamiento de la clase base.
        /// </summary>
        /// <returns>La imagen del enemigo como un string ("][").</returns>
        protected override string DevolverImagen()
        {
            return imagen;
        }

        /// <summary>
        /// Devuelve la longitud de la imagen del enemigo en caracteres.
        /// Este método sobreescribe el comportamiento de la clase base.
        /// </summary>
        /// <returns>La longitud de la imagen (2 caracteres).</returns>
        protected override int DevolverLongigud()
        {
            return 2;
        }
    }
}
