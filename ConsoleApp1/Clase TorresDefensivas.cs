using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Clase que representa las torres defensivas en el juego, que hereda de Clase_Sprite
    internal class Clase_TorresDefensivas : Clase_Sprite
    {
        // Variable que indica si la torre está activa o no
        bool activo;

        // Constructor que inicializa la torre en una posición (x, y) y la marca como activa
        public Clase_TorresDefensivas(int x, int y)
        {
            this.X = x; // Asigna la posición X de la torre
            this.Y = y; // Asigna la posición Y de la torre
            activo = true; // Marca la torre como activa
        }

        // Método que devuelve la representación visual de la torre (imagen)
        protected override string DevolverImagen()
        {
            return "--"; // La torre se representa como dos guiones
        }

        // Método que devuelve el color que se usará para dibujar la torre
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Green; // La torre se dibuja de color verde
        }

        // Método que devuelve la longitud de la torre (el número de caracteres que ocupa en la pantalla)
        protected override int DevolverLongigud()
        {
            return 2; // La torre ocupa 2 caracteres de longitud (los dos guiones)
        }

        // Propiedad para obtener o establecer si la torre está activa
        public bool Activo { get => activo; set => activo = value; }
    }
}
