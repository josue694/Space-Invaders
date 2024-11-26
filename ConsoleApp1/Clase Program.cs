using ConsoleApp1;  // Importa el espacio de nombres que contiene las clases del juego
using System;  // Importa el espacio de nombres base de C# para entrada y salida

namespace Space_Invaders  // Define el espacio de nombres del programa principal
{
    class Clase_Program  // Clase principal que contiene el método Main
    {
        public static void Main()  // Método principal que se ejecuta al iniciar el programa
        {
            // Crea una nueva instancia de la clase Clase_Juego, que gestiona todo el juego
            Clase_Juego juego = new Clase_Juego();

            // Llama al método Lanzar() que inicia el juego (pantalla de bienvenida, partida, etc.)
            juego.Lanzar();
        }
    }
}
