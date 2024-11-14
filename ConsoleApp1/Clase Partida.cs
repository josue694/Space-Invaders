using System;
using System.Threading;

namespace ConsoleApp1
{
    public class Clase_Partida
    {
        ConsoleKeyInfo tecla;
        Clase_Nave nave;
        Clase_BloqueDeEnemigos bloque;
        Clase_Disparo disparoNave;
        Clase_Disparo disparoEnemigo;
        Clase_Ovni ovni;
        Clase_Marcador marcador;
        bool finPartida;
        int numAleatorio;
        Random generador;

        public Clase_Partida()
        {
            nave = new Clase_Nave(40, 20);
            bloque = new Clase_BloqueDeEnemigos();
            disparoNave = null;
            disparoEnemigo = null;
            ovni = new Clase_Ovni();
            marcador = new Clase_Marcador();
            finPartida = false;
            generador = new Random();
        }

        public void GameOver()
        {
            Console.Clear();
            Console.SetCursorPosition(37, 12);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("GAME OVER");
            Console.CursorVisible = false;
            Console.ReadLine();
        }

        public void Lanzar()
        {
            Console.Clear();
            nave.Dibujar();
            bloque.Dibujar();

            do
            {
                Console.Clear();
                nave.Dibujar();
                bloque.Dibujar();
                bloque.Mover();
                ovni.Mover();
                ovni.Dibujar();
                marcador.ActualizarMarcador();

                numAleatorio = generador.Next(1, 7);
                if (numAleatorio == 3)
                {
                    disparoEnemigo = bloque.Disparar();
                }

                if (disparoNave != null && disparoNave.Activo)
                {
                    disparoNave.MoverArriba();
                    disparoNave.Dibujar();
                }

                if (disparoNave.ColisionaCon(ovni));
                {
                    disparoNave.Activo = false;
                    ovni.Activo = false;
                    marcador.SumarPuntos(50);
                }

                // Verificar colisión entre disparoNave y los enemigos
                for (int i = 0; i < 30; i++)
                {
                    if (disparoNave.ColisionaCon(bloque.Enemigos[i]) && bloque.Enemigos[i].Activo)
                    {
                        disparoNave.Activo = false;
                        bloque.Enemigos[i].Activo = false;
                        marcador.SumarPuntos(10);
                    }
                }
                if (disparoEnemigo != null && disparoEnemigo.Activo)
                {
                    disparoEnemigo.MoverAbajo();
                    disparoEnemigo.Dibujar();
                    if (disparoEnemigo.ColisionaCon(nave))
                    {
                        disparoEnemigo.Activo=false;
                        marcador.RestarVidas();
                        nave.Reset();
                        if (marcador.CuantasVidanQuedan() == 0)
                        {
                            GameOver();
                            finPartida = true;
                        }
                    }
                }
                for (int i = 0; 1 < 30; i++)
                {
                    if ((bloque.Enemigos[i].ColisionaCon(nave)) && (bloque.Enemigos[i].Activo))
                    {
                        GameOver();
                        finPartida = true;
                    }
                }  
                if (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey();
                    if (tecla.Key == ConsoleKey.RightArrow)
                        nave.MoverDerecha();
                    if (tecla.Key == ConsoleKey.LeftArrow)
                        nave.MoverIzquierda();
                    if (tecla.Key == ConsoleKey.Spacebar)
                        disparoNave = nave.Disparar();
                }

                Thread.Sleep(80);
            } while (!finPartida);
        }
    }
}
