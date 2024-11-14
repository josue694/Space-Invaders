using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Clase_Nave:Clase_Sprite
    {
        Clase_Disparo disparo;
        public Clase_Nave()
        {
            X = 40;
            Y = 20;
            imagen = "<->";
        }
        public Clase_Nave(int x, int y)
        {
            this.X = x;
            this.Y = y;
            imagen = "<->";
        }
        public void MoverDerecha()
        {
            X += 10;
            if (X >= 76) X = 76;
        }
        public void MoverIzquierda()
        {
            X -= 10;
            if (X <= 0) X = 0;
        }
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.White;
        }
        protected override string DevolverImagen()
        {
            return imagen;
        }
        public Clase_Disparo Disparar()
        {
            if (disparo == null || !disparo.Activo)
            {
                disparo = new Clase_Disparo(X, Y);
            }
            return disparo;
        }
        protected override int DevolverLongigud()
        {
            return 3;
        }
        public void Reset()
        {
            X = 40;
            Y = 20;
        }
    }
}
