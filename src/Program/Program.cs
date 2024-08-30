using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Consultar consulta = new Consultar();
            
            
            string ruta = @"C:\Repos\Game-of-Life\assets\board.txt";
            LeerArchivo leerArchivo = new LeerArchivo();
            bool[,] matriz = leerArchivo.crearTablero(ruta);
            
            Game partida = new Game();
            bool[,] matrizPartida = partida.startGame(matriz);

            for (int i = 0; i < 73; i++)
            {
                MostrarTablero mostrarTablero = new MostrarTablero();
                mostrarTablero.imprimirTablero(matrizPartida);

                matrizPartida = partida.startGame(matrizPartida);
            }
            Console.WriteLine("Terminatooooooooooooor");
        }
    }
}
