using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Clase principal que gestiona el flujo del juego, incluyendo la bienvenida, las partidas y el manejo de puntuaciones.
    /// </summary>
    internal class Clase_Juego
    {
        // Instancia de la clase que gestiona la pantalla de bienvenida.
        Clase_Bienvenida bienvenida;

        // Instancia de la clase que gestiona una partida específica.
        Clase_Partida partida;

        // Lista para almacenar las puntuaciones de los jugadores.
        List<int> puntuaciones;

        /// <summary>
        /// Constructor que inicializa los componentes necesarios para el juego.
        /// </summary>
        public Clase_Juego()
        {
            // Inicializa la pantalla de bienvenida.
            bienvenida = new Clase_Bienvenida();

            // Inicializa la lista de puntuaciones.
            puntuaciones = new List<int>();
        }

        /// <summary>
        /// Método que lanza el juego y gestiona el ciclo principal.
        /// </summary>
        public void Lanzar()
        {
            // Configura el tamaño de la ventana de la consola.
            Console.SetWindowSize(79, 24);

            // Ciclo principal del juego.
            do
            {
                // Muestra la pantalla de bienvenida con las puntuaciones actuales.
                bienvenida.Lanzar(puntuaciones);

                // Si el jugador no selecciona salir, inicia una nueva partida.
                if (!bienvenida.Salir)
                {
                    // Crea una nueva partida.
                    partida = new Clase_Partida();

                    // Agrega la puntuación obtenida a la lista de puntuaciones.
                    puntuaciones.Add(partida.Lanzar());

                    // Ordena las puntuaciones en orden descendente.
                    puntuaciones.Sort(CompararNumerosDescendiente);
                }

                // Repite mientras el jugador no seleccione salir.
            } while (!bienvenida.Salir);
        }

        /// <summary>
        /// Método auxiliar para comparar dos números en orden descendente.
        /// </summary>
        /// <param name="num1">Primer número a comparar.</param>
        /// <param name="num2">Segundo número a comparar.</param>
        /// <returns>
        /// 1 si num2 es mayor que num1,
        /// -1 si num2 es menor que num1,
        /// 0 si son iguales.
        /// </returns>
        private int CompararNumerosDescendiente(int num1, int num2)
        {
            if (num2 > num1)
                return 1;
            else if (num2 < num1)
                return -1;
            else
                return 0;
        }
    }
}
