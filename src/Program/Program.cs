using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ruta = "D:\\GitHub\\Game-of-Life\\assets\\board.txt;";
            //LeerArchivo leerArchivo = new LeerArchivo();
            //bool[,] matriz = leerArchivo.crearTablero(args);
        
             bool[,] matriz = new bool[20, 20]
        {
            { true,  false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, true,  true,  false, false, false, false, false, false, false, false, false, true,  true,  false, false, false, false, false, false },
            { true,  true,  false, false, false, false, false, false, false, false, false, false, true,  false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true,  false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, true,  true,  false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, true,  true,  false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, true,  false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, true,  false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, true,  false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }
        };
             
            Game partida = new Game();
            bool[,] matrizPartida = partida.startGame(matriz);
            
            while (true)
            {
                MostrarTablero mostrarTablero = new MostrarTablero();
                mostrarTablero.imprimirTablero(matrizPartida);

                matrizPartida = partida.startGame(matrizPartida);
            }
        }
    }
}
