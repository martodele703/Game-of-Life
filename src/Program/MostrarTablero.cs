using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class MostrarTablero
{
    public void imprimirTablero(Tablero tablero)
    {
        bool[,] b = tablero.; //variable que representa el tablero
        int width = tablero.Width; //variabe que representa el ancho del tablero
        int height = tablero.Hight;//variabe que representa altura del tablero
        Console.Clear();
        StringBuilder s = new StringBuilder();
        for (int y = 0; y<height;y++)
        {
            for (int x = 0; x<width; x++)
            {
                if(b[x,y])
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }
            s.Append("\n");
        }
        Console.WriteLine(s.ToString());
        //=================================================
        //Invocar método para calcular siguiente generación
        //=================================================
        Thread.Sleep(300);
    }
}