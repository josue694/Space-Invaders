using System;
using System.Threading;

namespace ConsoleApp1
{
    /// <summary>
    /// Clase principal que gestiona la lógica del juego Space Invaders.
    /// </summary>
    public class Clase_Partida
    {
        // Variables de instancia
        ConsoleKeyInfo tecla; // Almacena la tecla pulsada por el jugador
        Clase_Nave nave; // Representa la nave del jugador
        Clase_BloqueDeEnemigos bloque; // Representa el grupo de enemigos
        Clase_Disparo disparoNave; // Representa el disparo de la nave del jugador
        Clase_Disparo disparoEnemigo; // Representa el disparo de un enemigo
        Clase_Ovni ovni; // Representa un enemigo especial (OVNI)
        Clase_Marcador marcador; // Lleva el puntaje y controla las vidas del jugador
        bool finPartida; // Controla si la partida ha terminado
        int numAleatorio; // Genera valores aleatorios para ciertos eventos
        Random generador; // Generador de números aleatorios

        /// <summary>
        /// Constructor que inicializa todos los elementos de la partida.
        /// </summary>
        public Clase_Partida()
        {
            nave = new Clase_Nave(40, 20); // Inicializa la nave en una posición predeterminada
            bloque = new Clase_BloqueDeEnemigos(); // Inicializa el grupo de enemigos
            disparoNave = null; // No hay disparos iniciales desde la nave
            disparoEnemigo = null; // No hay disparos iniciales desde los enemigos
            ovni = new Clase_Ovni(); // Inicializa el OVNI
            marcador = new Clase_Marcador(); // Inicializa el marcador
            finPartida = false; // La partida comienza sin haber terminado
            generador = new Random(); // Inicializa el generador de números aleatorios
        }

        /// <summary>
        /// Muestra el mensaje de "Game Over" en pantalla.
        /// </summary>
        public void GameOver()
        {
            Console.Clear(); // Limpia la pantalla
            Console.SetCursorPosition(37, 12); // Ubica el cursor en el centro de la pantalla
            Console.ForegroundColor = ConsoleColor.Cyan; // Cambia el color del texto
            Console.Write("GAME OVER"); // Muestra el mensaje de "Game Over"
            Console.CursorVisible = false; // Oculta el cursor
            Console.ReadLine(); // Pausa la ejecución hasta que el usuario presione Enter
        }

        /// <summary>
        /// Ejecuta la lógica principal del juego.
        /// </summary>
        /// <returns>La puntuación final obtenida por el jugador.</returns>
        public int Lanzar()
        {
            // Limpia la pantalla y dibuja los elementos iniciales
            Console.Clear();
            nave.Dibujar(); // Dibuja la nave del jugador
            bloque.Dibujar(); // Dibuja el grupo de enemigos
            disparoNave = new Clase_Disparo(this.nave.X, this.nave.Y - 1); // Inicializa un disparo desde la nave

            // Bucle principal del juego
            do
            {
                Console.Clear(); // Limpia la pantalla en cada iteración
                nave.Dibujar(); // Redibuja la nave
                bloque.Dibujar(); // Redibuja los enemigos
                bloque.Mover(); // Mueve a los enemigos
                ovni.Mover(); // Mueve el OVNI
                ovni.Dibujar(); // Dibuja el OVNI
                marcador.ActualizarMarcador(); // Actualiza el marcador en pantalla

                // Genera disparos aleatorios desde los enemigos
                numAleatorio = generador.Next(1, 7); // Genera un número aleatorio entre 1 y 6
                if (numAleatorio == 3) // Si el número es 3, dispara un enemigo
                {
                    disparoEnemigo = bloque.Disparar();
                }

                // Gestión de disparos desde la nave
                if (disparoNave != null && disparoNave.Activo)
                {
                    disparoNave.MoverArriba(); // Mueve el disparo hacia arriba
                    disparoNave.Dibujar(); // Dibuja el disparo en su nueva posición
                }

                // Detecta colisión del disparo de la nave con el OVNI
                if (disparoNave.ColisionaCon(ovni))
                {
                    disparoNave.Activo = false; // Desactiva el disparo
                    ovni.Activo = false; // Desactiva el OVNI
                    marcador.SumarPuntos(50); // Añade puntos al marcador
                }

                // Detecta colisiones del disparo de la nave con los enemigos
                for (int i = 0; i < 30; i++) // Itera sobre todos los enemigos
                {
                    if (disparoNave.ColisionaCon(bloque.Enemigos[i]) && bloque.Enemigos[i].Activo)
                    {
                        disparoNave.Activo = false; // Desactiva el disparo
                        bloque.Enemigos[i].Activo = false; // Desactiva al enemigo
                        marcador.SumarPuntos(10); // Añade puntos al marcador
                    }
                }

                // Gestión de disparos enemigos
                if (disparoEnemigo != null && disparoEnemigo.Activo)
                {
                    disparoEnemigo.MoverAbajo(); // Mueve el disparo hacia abajo
                    disparoEnemigo.Dibujar(); // Dibuja el disparo
                    if (disparoEnemigo.ColisionaCon(nave)) // Detecta colisión con la nave del jugador
                    {
                        disparoEnemigo.Activo = false; // Desactiva el disparo
                        marcador.RestarVidas(); // Resta una vida al jugador
                        nave.Reset(); // Resetea la posición de la nave
                        if (marcador.CuantasVidanQuedan() == 0) // Si no quedan vidas
                        {
                            GameOver(); // Termina el juego
                            finPartida = true; // Marca el fin de la partida
                        }
                    }
                }

                // Detecta colisiones entre la nave y los enemigos
                for (int i = 0; i < 30; i++)
                {
                    if (bloque.Enemigos[i].ColisionaCon(nave) && bloque.Enemigos[i].Activo)
                    {
                        GameOver(); // Termina el juego
                        finPartida = true; // Marca el fin de la partida
                    }
                }

                // Detecta entrada del usuario para mover la nave o disparar
                if (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey(); // Lee la tecla pulsada
                    if (tecla.Key == ConsoleKey.RightArrow) // Mueve la nave a la derecha
                        nave.MoverDerecha();
                    if (tecla.Key == ConsoleKey.LeftArrow) // Mueve la nave a la izquierda
                        nave.MoverIzquierda();
                    if (tecla.Key == ConsoleKey.Spacebar) // Dispara
                        disparoNave = nave.Disparar();
                }

                Thread.Sleep(80); // Pausa breve para controlar la velocidad del juego
            } while (!finPartida); // Repite mientras no se termine la partida

            return marcador.DevolverPuntuacionFinal(); // Devuelve la puntuación final
        }
    }
}
