using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  abstract class Clase_Sprite
    {
        protected string imagen;
        private int x;
        private int y;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public void Dibujar()
        {
            Console.SetCursorPosition(X,Y);
            Console.ForegroundColor = DevolverColor();
            Console.Write(DevolverImagen());
            Console.CursorVisible = false;
        }
        protected abstract string DevolverImagen();
        protected abstract ConsoleColor DevolverColor();
        protected abstract int DevolverLongigud();
        public bool ColisionaCon(Clase_Sprite sprite)
        {
            if (this.Y != sprite.Y)
                return false;
            else
            {
                for (int i = 0; i < this.DevolverLongigud(); i++)
                {
                    for (int j = 0; j < sprite.DevolverLongigud(); j++)
                    {
                        if ((this.X + i)== (sprite.X + j))
                            return true;
                    }
                }
            }
            return false;
            
        }
    }
}
