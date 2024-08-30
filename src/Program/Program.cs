using System;
using System.IO;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creación del tablero
            string ruta = @"C:\Repos\Game-of-Life\assets\board.txt";
            LeerArchivo leerArchivo = new LeerArchivo();
            bool[,] matriz = leerArchivo.crearTablero(ruta);

            // Mostrar la ruta actual en la consola
            Console.WriteLine(@"La ruta actual es: C:\Repos\Game-of-Life\assets\board.txt");
            Console.WriteLine("Presiona Enter para continuar...");

            // Bucle del juego, mientras que el usuario no ingrese "n" el juego se repite
            string selector = "";
            while (selector != "n")
            {
                Console.Clear();
                Console.WriteLine("Pulse cualquier tecla para comenzar");
                string aux = Console.ReadLine();

                // Bucle de 73 generaciones de juego
                Game partida = new Game();
                bool[,] matrizPartida = partida.startGame(matriz);
                for (int i = 0; i < 73; i++)
                {
                    MostrarTablero mostrarTablero = new MostrarTablero();
                    mostrarTablero.imprimirTablero(matrizPartida);

                    matrizPartida = partida.startGame(matrizPartida);
                }
                Console.WriteLine("Fin.");
                selector = "";

                // Opción para volver a jugar
                Console.WriteLine("Quiere volver a jugar? s / n");

                // Bucle en el caso de que el usuario ingrese cualquier otra tecla
                while (selector != "s" && selector != "n")
                {
                    selector = Console.ReadLine();

                    if (selector != "s" && selector != "n")
                    {
                        Console.WriteLine("Ingrese un valor correcto: s o n.");
                    }
                }
            }
        }
    }
}
