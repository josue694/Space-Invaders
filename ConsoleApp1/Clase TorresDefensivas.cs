using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clase_TorresDefensivas:Clase_Sprite
    {
        bool activo;
        public Clase_TorresDefensivas(int x, int y)
        {
            this.X = x;
            this.Y = y;
            activo = true;
        }
        protected override string DevolverImagen()
        {
            return "--";
        }
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Green;
        }
        protected override int DevolverLongigud()
        {
            return 2;
        }
        public bool Activo { get => activo; set => activo = value; }
    }
}
