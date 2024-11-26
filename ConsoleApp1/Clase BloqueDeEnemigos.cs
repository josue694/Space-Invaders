using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Clase que representa un bloque de enemigos en el juego Space Invaders.
    public class Clase_BloqueDeEnemigos
    {
        // Coordenadas iniciales del bloque de enemigos.
        int x, y;

        // Incremento que controla el movimiento horizontal del bloque.
        int incremento;

        // Instancia del disparo que puede ser lanzado por los enemigos.
        Clase_Disparo disparo;

        // Generador de números aleatorios para seleccionar un enemigo que dispare.
        Random generador;

        // Número aleatorio que representa el índice del enemigo que disparará.
        int numAleatorio;

        /// <summary>
        /// Constructor de la clase. Inicializa el bloque de enemigos con sus posiciones y tipos.
        /// </summary>
        public Clase_BloqueDeEnemigos()
        {
            generador = new Random(); // Inicializa el generador de números aleatorios.
            Enemigos = new Clase_Enemigo[30]; // Crea un array de 30 enemigos.
            x = 20; // Coordenada inicial en X del bloque.
            y = 12; // Coordenada inicial en Y del bloque.
            incremento = 1; // Incremento inicial para el movimiento.

            // Inicializa los primeros 10 enemigos (tipo Clase_Enemigo).
            for (int i = 0; i < 10; i++)
                Enemigos[i] = new Clase_Enemigo(x + (i * 4), y - 4);

            // Inicializa los siguientes 10 enemigos (tipo Clase_Enemigo1).
            for (int i = 0; i < 10; i++)
                Enemigos[i + 10] = new Clase_Enemigo1(x + (i * 4), y - 2);

            // Inicializa los últimos 10 enemigos (tipo Clase_Enemigo2).
            for (int i = 0; i < 10; i++)
                Enemigos[i + 20] = new Clase_Enemigo2(x + (i * 4), y);
        }

        /// <summary>
        /// Array que contiene todos los enemigos del bloque.
        /// </summary>
        public Clase_Enemigo[] Enemigos { get; set; }

        /// <summary>
        /// Dibuja todos los enemigos activos en la consola.
        /// </summary>
        public void Dibujar()
        {
            for (int i = 0; i < 30; i++)
            {
                if (Enemigos[i].Activo) // Solo dibuja enemigos activos.
                    Enemigos[i].Dibujar();
            }
        }

        /// <summary>
        /// Mueve el bloque de enemigos horizontalmente, y si llega al límite,
        /// lo desplaza hacia abajo y cambia la dirección del movimiento.
        /// </summary>
        public void Mover()
        {
            x += incremento; // Incrementa la posición horizontal.

            // Cambia de dirección si se alcanza un límite horizontal.
            if (x < 1 || x >= 40)
            {
                y++; // Desplaza el bloque hacia abajo.
                incremento = -incremento; // Invierte la dirección.
            }

            // Actualiza las posiciones de los primeros 10 enemigos.
            for (int i = 0; i < 10; i++)
            {
                Enemigos[i].X = x + (i * 4);
                Enemigos[i].Y = y - 4;
            }

            // Actualiza las posiciones de los siguientes 10 enemigos.
            for (int i = 0; i < 10; i++)
            {
                Enemigos[i + 10].X = x + (i * 4);
                Enemigos[i + 10].Y = y - 2;
            }

            // Actualiza las posiciones de los últimos 10 enemigos.
            for (int i = 0; i < 10; i++)
            {
                Enemigos[i + 20].X = x + (i * 4);
                Enemigos[i + 20].Y = y;
            }
        }

        /// <summary>
        /// Selecciona aleatoriamente un enemigo para que dispare.
        /// </summary>
        /// <returns>Devuelve una instancia de Clase_Disparo.</returns>
        public Clase_Disparo Disparar()
        {
            numAleatorio = generador.Next(1, 30); // Selecciona un enemigo al azar.

            // Si no hay un disparo activo, crea uno nuevo desde el enemigo seleccionado.
            if (disparo == null || !disparo.Activo)
            {
                disparo = new Clase_Disparo(Enemigos[numAleatorio].X, Enemigos[numAleatorio].Y);
            }

            return disparo;
        }

        /// <summary>
        /// Reinicia las posiciones y estados del bloque de enemigos.
        /// </summary>
        public void Reset()
        {
            // Reinicia el array de enemigos.
            Enemigos = new Clase_Enemigo[30];
            x = 20; // Reinicia la posición X.
            y = 12; // Reinicia la posición Y.

            // Reinicia las posiciones de los primeros 10 enemigos.
            for (int i = 0; i < 10; i++)
                Enemigos[i] = new Clase_Enemigo(x + (i * 4), y - 4);

            // Reinicia las posiciones de los siguientes 10 enemigos.
            for (int i = 0; i < 10; i++)
                Enemigos[i + 10] = new Clase_Enemigo1(x + (i * 4), y - 2);

            // Reinicia las posiciones de los últimos 10 enemigos.
            for (int i = 0; i < 10; i++)
                Enemigos[i + 20] = new Clase_Enemigo2(x + (i * 4), y);
        }
    }
}

