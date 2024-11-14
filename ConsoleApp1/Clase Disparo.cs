using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clase_Disparo:Clase_Sprite
    {
        private bool activo;
        public bool Activo { get => activo; set => activo = value; }
        public Clase_Disparo(int x, int y)
        {
            this.X = x;
            this.Y = y;
            activo = true;
        }
        protected override string DevolverImagen()
        {
            return "|";
        }
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Yellow;
        }
        public void MoverArriba()
        {
            Y--;
            if (Y == 0) activo = false;
        }
        public void MoverAbajo()
        {
            Y++;
            if(Y >=23) activo=false;
        }
        protected override int DevolverLongigud()
        {
            return 1;
        }
    }
}
