using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Representa un disparo dentro del juego, ya sea realizado por el jugador o los enemigos.
    /// Hereda de la clase base Clase_Sprite para utilizar sus propiedades y métodos.
    /// </summary>
    public class Clase_Disparo : Clase_Sprite
    {
        // Indica si el disparo está activo (es visible y puede interactuar con otros objetos).
        private bool activo;

        // Propiedad pública para acceder o modificar el estado de actividad del disparo.
        public bool Activo { get => activo; set => activo = value; }

        /// <summary>
        /// Constructor de la clase disparo. Inicializa las coordenadas del disparo y lo activa.
        /// </summary>
        /// <param name="x">Coordenada inicial en X del disparo.</param>
        /// <param name="y">Coordenada inicial en Y del disparo.</param>
        public Clase_Disparo(int x, int y)
        {
            this.X = x; // Establece la posición inicial en X.
            this.Y = y; // Establece la posición inicial en Y.
            activo = true; // Marca el disparo como activo.
        }

        /// <summary>
        /// Devuelve el carácter que representa la imagen del disparo.
        /// Este método sobreescribe la implementación de la clase base.
        /// </summary>
        /// <returns>Una cadena que representa la imagen del disparo ("|").</returns>
        protected override string DevolverImagen()
        {
            return "|";
        }

        /// <summary>
        /// Devuelve el color del disparo para ser mostrado en la consola.
        /// Este método sobreescribe la implementación de la clase base.
        /// </summary>
        /// <returns>El color amarillo para el disparo.</returns>
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Yellow;
        }

        /// <summary>
        /// Mueve el disparo hacia arriba. Si llega al límite superior de la consola,
        /// se desactiva el disparo.
        /// </summary>
        public void MoverArriba()
        {
            Y--; // Reduce la posición Y (hacia arriba).
            if (Y == 0) activo = false; // Si el disparo alcanza el borde superior, se desactiva.
        }

        /// <summary>
        /// Mueve el disparo hacia abajo. Si llega al límite inferior de la consola,
        /// se desactiva el disparo.
        /// </summary>
        public void MoverAbajo()
        {
            Y++; // Incrementa la posición Y (hacia abajo).
            if (Y >= 23) activo = false; // Si el disparo alcanza el borde inferior, se desactiva.
        }

        /// <summary>
        /// Devuelve la longitud del disparo. En este caso, es un disparo de un solo carácter.
        /// Este método sobreescribe la implementación de la clase base.
        /// </summary>
        /// <returns>La longitud del disparo (1).</returns>
        protected override int DevolverLongigud()
        {
            return 1;
        }
    }
}
