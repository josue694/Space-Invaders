using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Clase_Enemigo1:Clase_Enemigo
    {
        public Clase_Enemigo1(int x, int y)
        {
            this.X = x;
            this.Y = y;
            imagen = "}{";
        }
        protected override string DevolverImagen()
        {
            return imagen;
        }
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Blue;
        }

    }
}
