using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Clase_Bienvenida
    {
        ConsoleKeyInfo tecla;
        public bool Salir { get; private set; }
        public void Lanzar(List<int> puntuaciones)
        {
            Console.Clear();
            Console.SetCursorPosition(33, 6);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("SPACE INVADERS");
            Console.SetCursorPosition(20, 7);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(Pulsa Intro para jugar o ESC para salir");
            Console.SetCursorPosition(30, 10);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("MEJORES PUNTUACIONES: ");
            for (int i = 0; i < puntuaciones.Count && i < 3; i++)
            {
                Console.SetCursorPosition(30, 11 + 1);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("{0}) {1}",i+1,puntuaciones[i]);
            }
            Console.CursorVisible = false;
            tecla = Console.ReadKey();
            if (tecla.Key== ConsoleKey.Escape)
            {
                Salir = true;
            } 
        }
    }
}
