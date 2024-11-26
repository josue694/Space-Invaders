using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Clase que representa la nave del jugador en el juego.
    /// Hereda de la clase Clase_Sprite y agrega funcionalidades específicas para la nave.
    /// </summary>
    class Clase_Nave : Clase_Sprite
    {
        // Disparo actual realizado por la nave.
        Clase_Disparo disparo;

        /// <summary>
        /// Constructor predeterminado que inicializa la posición y la imagen de la nave.
        /// </summary>
        public Clase_Nave()
        {
            X = 40; // Posición inicial horizontal de la nave.
            Y = 20; // Posición inicial vertical de la nave.
            imagen = "<->"; // Representación visual de la nave.
        }

        /// <summary>
        /// Constructor que permite especificar la posición inicial de la nave.
        /// </summary>
        /// <param name="x">Posición inicial en el eje X.</param>
        /// <param name="y">Posición inicial en el eje Y.</param>
        public Clase_Nave(int x, int y)
        {
            this.X = x;
            this.Y = y;
            imagen = "<->"; // Representación visual de la nave.
        }

        /// <summary>
        /// Mueve la nave hacia la derecha. Limita su posición para que no salga de la pantalla.
        /// </summary>
        public void MoverDerecha()
        {
            X += 10; // Incrementa la posición horizontal.
            if (X >= 76) X = 76; // Limita la posición al borde derecho de la pantalla.
        }

        /// <summary>
        /// Mueve la nave hacia la izquierda. Limita su posición para que no salga de la pantalla.
        /// </summary>
        public void MoverIzquierda()
        {
            X -= 10; // Decrementa la posición horizontal.
            if (X <= 0) X = 0; // Limita la posición al borde izquierdo de la pantalla.
        }

        /// <summary>
        /// Devuelve el color de la nave al dibujarla en pantalla.
        /// </summary>
        /// <returns>Color de la nave.</returns>
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.White; // La nave se dibuja en color blanco.
        }

        /// <summary>
        /// Devuelve la imagen de la nave.
        /// </summary>
        /// <returns>Representación visual de la nave.</returns>
        protected override string DevolverImagen()
        {
            return imagen; // Retorna la cadena "<->".
        }

        /// <summary>
        /// Realiza un disparo desde la posición actual de la nave.
        /// </summary>
        /// <returns>Una instancia de Clase_Disparo activa.</returns>
        public Clase_Disparo Disparar()
        {
            // Verifica si no hay un disparo activo o no existe uno actual.
            if (disparo == null || !disparo.Activo)
            {
                disparo = new Clase_Disparo(X, Y); // Crea un nuevo disparo en la posición actual de la nave.
            }
            return disparo; // Retorna el disparo creado o ya existente.
        }

        /// <summary>
        /// Devuelve la longitud de la imagen de la nave.
        /// </summary>
        /// <returns>Longitud de la imagen (número de caracteres).</returns>
        protected override int DevolverLongigud()
        {
            return 3; // La imagen "<->" tiene 3 caracteres.
        }

        /// <summary>
        /// Restaura la posición de la nave a su posición inicial.
        /// </summary>
        public void Reset()
        {
            X = 40; // Restablece la posición horizontal inicial.
            Y = 20; // Restablece la posición vertical inicial.
        }
    }
}
