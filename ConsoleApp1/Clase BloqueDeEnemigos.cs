using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Clase_BloqueDeEnemigos
    {
        int x, y;
        int incremento;
        Clase_Disparo disparo;
        Random generador;
        int numAleatorio;
        public Clase_BloqueDeEnemigos()
        {
            generador = new Random();
            Enemigos = new Clase_Enemigo[30];
            x = 20;
            y = 12;
            incremento = 1;
            for (int i = 0; i < 10; i++)
                Enemigos[i] = new Clase_Enemigo(x + (i * 4), y - 4);
            for (int i = 0; i < 10; i++)
                Enemigos[i+10] = new Clase_Enemigo1(x + (i * 4), y - 2);
            for (int i = 0; i < 10; i++)
                Enemigos[i-20] = new Clase_Enemigo2(x + (i * 4), y);
        }
        public Clase_Enemigo[] Enemigos { get; set; }
        public void Dibujar()
        {
            for (int i = 0;i < 30; i++)
            {
                if (Enemigos[i].Activo)
                    Enemigos[i].Dibujar();
            }
        }
        public void Mover()
        {
            x += incremento;
            if (x < 0 || x >= 40)
            {
                y++;
                incremento = -incremento;
            }
            for(int i = 0; i < 10; i++)
            {
                Enemigos[i].X = x+(i * 4);
                Enemigos[i].Y = y-4;
            }
            for (int i = 0; i < 10; i++)
            {
                Enemigos[i+10].X = x + (i * 4);
                Enemigos[i+10].Y = y - 2;
            }
            for (int i = 0; i < 10; i++)
            {
                Enemigos[i + 20].X = x + (i * 4);
                Enemigos[i + 20].Y = y;
            }
        }
        public Clase_Disparo Disparar()
        {
            numAleatorio = generador.Next(1, 30);
            if (disparo == null || !disparo.Activo)
            {
                disparo = new Clase_Disparo(Enemigos[numAleatorio].X,Enemigos[numAleatorio].Y);
            }
            return disparo;
        }
        public void Reset()
        {
            Enemigos = new Clase_Enemigo[30];
            x = 20;
            y = 12;
            for (int i = 0; i < 10; i++)
                Enemigos[i] = new Clase_Enemigo(x + (i * 4), y - 4);
            for (int i = 0; i < 10; i++)
                Enemigos[i+10] = new Clase_Enemigo1(x + (i * 4), y - 2);
            for (int i = 0; i < 10; i++)
                Enemigos[i+20] = new Clase_Enemigo2(x + (i * 4), y);




        }

        
    }

}

