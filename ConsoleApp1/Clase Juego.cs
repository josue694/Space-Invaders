using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clase_Juego
    {
        Clase_Bienvenida bienvenida;
        Clase_Partida partida;
        List<int> puntuaciones;
        public Clase_Juego()
        {
            bienvenida = new Clase_Bienvenida();
            puntuaciones = new List<int>();
        }
        public void Lanzar()
        {
            Console.SetWindowSize(79, 24);
            do
            {
                bienvenida.Lanzar(puntuaciones);
                if (!bienvenida.Salir)
                {
                    partida = new Clase_Partida();
                    puntuaciones.Add(partida.Lanzar());
                    puntuaciones.Sort(CompararNumerosDescendiente);
               
                }
            }while (!bienvenida.Salir);
        }
        private int CompararNumerosDescendiente(int num1, int num2)
        {
            if (num2 > num1)
                return 1;
            else if (num2 < num1)
                return -1;

            else
                return 0;

        }


    }
}
