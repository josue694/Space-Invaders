using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Clase que gestiona el marcador del juego, incluyendo vidas y puntuación del jugador.
    /// </summary>
    internal class Clase_Marcador
    {
        // Número de vidas restantes del jugador.
        int vidas = 3;

        // Puntuación actual del jugador.
        int score = 0;

        /// <summary>
        /// Constructor que inicializa el marcador con valores predeterminados (3 vidas y 0 puntos).
        /// </summary>
        public Clase_Marcador()
        {
            vidas = 3;
            score = 0;
        }

        /// <summary>
        /// Actualiza el marcador en la pantalla, mostrando las vidas y la puntuación actual.
        /// </summary>
        public void ActualizarMarcador()
        {
            // Posiciona el cursor en la consola para escribir el marcador.
            Console.SetCursorPosition(3, 1);

            // Cambia el color del texto a blanco.
            Console.ForegroundColor = ConsoleColor.White;

            // Muestra el número de vidas y la puntuación.
            Console.Write("VIDAS: {0}\tSCORE: {1}", vidas, score);

            // Oculta el cursor de la consola.
            Console.CursorVisible = false;
        }

        /// <summary>
        /// Suma puntos al marcador.
        /// </summary>
        /// <param name="puntos">Cantidad de puntos a sumar.</param>
        /// <returns>La puntuación actualizada.</returns>
        public int SumarPuntos(int puntos)
        {
            return score += puntos;
        }

        /// <summary>
        /// Resta una vida al jugador.
        /// </summary>
        public void RestarVidas()
        {
            vidas--;
        }

        /// <summary>
        /// Devuelve el número de vidas restantes.
        /// </summary>
        /// <returns>Cantidad de vidas restantes.</returns>
        public int CuantasVidanQuedan()
        {
            return vidas;
        }

        /// <summary>
        /// Devuelve la puntuación final del jugador.
        /// </summary>
        /// <returns>Puntuación final.</returns>
        public int DevolverPuntuacionFinal()
        {
            return score;
        }

        /// <summary>
        /// Agrega una vida extra al jugador.
        /// </summary>
        public void VidaExtra()
        {
            vidas++;
        }
    }
}
