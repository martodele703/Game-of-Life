using System;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class Tablero
{
    private int hight;
    private int width;

    public int Hight
    {
        get { return hight; }
        set
        {
            if (!(value == 0))
            {
                hight = value;
            }
        }
    }
    public int Width
    {
        get { return width; }
        set
        {
            if (!(value == 0))
            {
                width = value;
            }
        }
    }
}