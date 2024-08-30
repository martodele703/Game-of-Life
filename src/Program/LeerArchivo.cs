using System.IO;

namespace Ucu.Poo.GameOfLife;

public class LeerArchivo
{
    /*Funcion encargada de crear la matriz booleana a partir de un archivo txt
      La ruta al archivo se pasa como parametro*/
    public bool[,] crearTablero(string ruta)
    {
        string url = ruta;
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        for (int  y=0; y<contentLines.Length;y++)
        {
            for (int x=0; x<contentLines[y].Length; x++)
            {
                if(contentLines[y][x]=='1')
                {
                    board[x,y]=true;
                }
            }
        }
        return board;
    }
}