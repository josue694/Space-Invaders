using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clase_Marcador
    {
        int vidas = 3;
        int score = 0;
        public Clase_Marcador()
        {
            vidas = 3;
            score = 0;
        }
        public void ActualizarMarcador()
        {
            Console.SetCursorPosition(3,1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("VIDAS: {0}\tSCORE: {1}", vidas, score);
            Console.CursorVisible = false;
        }
        public int SumarPuntos(int puntos)
        {
            return score += puntos;
        }
        public void RestarVidas()
        {
            vidas--;
        }
        public int CuantasVidanQuedan()
        {
            return vidas;
        }
        public int DevolverPuntuacionFinal()
        {
            return score;
        }
        public void VidaExtra()
        {
            vidas++;
        }
        
    }
}
