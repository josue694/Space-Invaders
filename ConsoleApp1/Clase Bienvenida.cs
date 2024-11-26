using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Clase que gestiona la pantalla de bienvenida del juego "Space Invaders"
    public class Clase_Bienvenida
    {
        // Almacena la tecla presionada por el usuario
        ConsoleKeyInfo tecla;

        // Propiedad que indica si el jugador desea salir del juego
        public bool Salir { get; private set; }

        /// <summary>
        /// Método que lanza la pantalla de bienvenida y gestiona la interacción del usuario.
        /// </summary>
        /// <param name="puntuaciones">Lista de las puntuaciones más altas obtenidas en el juego</param>
        public void Lanzar(List<int> puntuaciones)
        {
            // Limpia la consola antes de mostrar la pantalla de bienvenida
            Console.Clear();

            // Configura y muestra el título del juego
            Console.SetCursorPosition(33, 6); // Establece la posición para el título
            Console.ForegroundColor = ConsoleColor.Yellow; // Cambia el color del texto
            Console.Write("SPACE INVADERS");

            // Muestra las instrucciones para el usuario
            Console.SetCursorPosition(20, 7); // Establece la posición para las instrucciones
            Console.ForegroundColor = ConsoleColor.White; // Cambia el color del texto
            Console.Write("(Pulsa Intro para jugar o ESC para salir");

            // Muestra el encabezado de mejores puntuaciones
            Console.SetCursorPosition(30, 10); // Posiciona el texto
            Console.ForegroundColor = ConsoleColor.Gray; // Cambia el color del texto
            Console.Write("MEJORES PUNTUACIONES: ");

            // Recorre y muestra las tres mejores puntuaciones (si existen)
            for (int i = 0; i < puntuaciones.Count && i < 3; i++)
            {
                // Establece la posición para cada puntuación (una línea debajo de la anterior)
                Console.SetCursorPosition(30, 11 + i);
                Console.ForegroundColor = ConsoleColor.Gray; // Cambia el color del texto
                Console.Write("{0}) {1}", i + 1, puntuaciones[i]); // Muestra la posición y la puntuación
            }

            // Oculta el cursor para mejorar la presentación
            Console.CursorVisible = false;

            // Captura la tecla presionada por el usuario
            tecla = Console.ReadKey();

            // Verifica si el usuario presionó la tecla ESC para salir del juego
            if (tecla.Key == ConsoleKey.Escape)
            {
                Salir = true; // Cambia la propiedad Salir a verdadero
            }
        }
    }
}
