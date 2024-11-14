using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Clase_Enemigo:Clase_Sprite
    {
        bool activo;
        public Clase_Enemigo()
        {
            X = 40;
            Y = 10;
            imagen = "][";
            activo = true;
        }
        public Clase_Enemigo(int x, int y)
        {
            this.X = x;
            this.Y = y;
            imagen = "][";
            activo= true;
        }
        public bool Activo { get => activo; set => activo = value; }
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Yellow;
        }
        protected override string DevolverImagen()
        {
            return imagen;
        }
        protected override int DevolverLongigud()
        {
            return 2;
        }
    }
}
