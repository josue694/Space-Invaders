using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clase_Enemigo2:Clase_Enemigo
    {
        public Clase_Enemigo2(int x, int y)
        {
            this.X = x;
            this.Y = y;
            imagen = ")(";
        }
        protected override string DevolverImagen()
        {
            return imagen;
        }
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Green;
        }
    }
}
