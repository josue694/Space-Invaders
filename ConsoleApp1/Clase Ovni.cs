using System;

namespace ConsoleApp1
{
    /// <summary>
    /// Clase que representa un objeto tipo OVNI en el juego.
    /// Hereda de Clase_Sprite y tiene funcionalidades para moverse y aparecer de manera aleatoria.
    /// </summary>
    internal class Clase_Ovni : Clase_Sprite
    {
        // Instancia de la clase Random para generar números aleatorios.
        Random generador;
        // Variable que almacena el valor aleatorio generado.
        int aleatorio;
        // Variable que indica si el OVNI está activo o no en el juego.
        bool activo;

        /// <summary>
        /// Constructor predeterminado que inicializa la posición del OVNI y su estado.
        /// </summary>
        public Clase_Ovni()
        {
            X = 0; // Posición horizontal inicial del OVNI.
            Y = 6; // Posición vertical inicial del OVNI.
            activo = false; // Inicialmente, el OVNI no está activo.
            generador = new Random(); // Se crea un generador de números aleatorios.
            imagen = "(||)"; // Representación visual del OVNI.
        }

        /// <summary>
        /// Propiedad que indica si el OVNI está activo o no.
        /// </summary>
        public bool Activo
        {
            get => activo;
            set => activo = value;
        }

        /// <summary>
        /// Devuelve la imagen del OVNI si está activo, o una cadena vacía si no lo está.
        /// </summary>
        /// <returns>Imagen del OVNI o una cadena vacía si no está activo.</returns>
        protected override string DevolverImagen()
        {
            if (activo)
                return "(||)"; // Devuelve la imagen del OVNI cuando está activo.
            else
                return ""; // Devuelve una cadena vacía cuando no está activo.
        }

        /// <summary>
        /// Devuelve el color del OVNI al dibujarlo en pantalla.
        /// </summary>
        /// <returns>Color amarillo para el OVNI.</returns>
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Yellow; // El OVNI es de color amarillo.
        }

        /// <summary>
        /// Mueve el OVNI en la pantalla de manera aleatoria y lo activa o desactiva.
        /// </summary>
        public void Mover()
        {
            if (!activo)
            {
                // Si el OVNI no está activo, genera un número aleatorio entre 1 y 60.
                aleatorio = generador.Next(1, 61);
                // Si el número generado es 2, el OVNI se activa y aparece en la posición X = 0.
                if (aleatorio == 2)
                {
                    activo = true; // El OVNI se activa.
                    X = 0; // Posiciona el OVNI en la coordenada horizontal 0.
                }
            }
            else
            {
                // Si el OVNI está activo, se mueve incrementando su posición en el eje X.
                X++;
                // Si el OVNI llega al borde derecho de la pantalla (X >= 76), se desactiva.
                if (X >= 76) activo = false;
            }
        }

        /// <summary>
        /// Devuelve la longitud de la imagen del OVNI.
        /// </summary>
        /// <returns>Longitud de la imagen del OVNI (4 caracteres).</returns>
        protected override int DevolverLongigud()
        {
            return 4; // La longitud de la imagen "(||)" es 4 caracteres.
        }
    }
}
