using System;
using System.Net.Http;

namespace Ucu.Poo.GameOfLife;

public class Consultar
{
    private string path;
    private int generations;

    public string Path
    {
        get { return path; }
        set
        {
            if (value is string)
            {
                path = value;
            }
        }
    }
    
    public int Generations
    {
        get { return generations; }
        set
        {
            if (value > 0)
            {
                generations = value;
            }
        }
    }

    public void consultar()
    {
        Console.WriteLine("Introduzca la ruta a su autómata celular: ");
        // Leer la entrada del usuario desde la consola y guardarla en nombre
        string ruta = Console.ReadLine();
        
        Console.WriteLine("Introduzca la cantidad de generaciones: ");
        string genString = Console.ReadLine();
        
        // Transformar a int lo leido en consola
        int genInt = int.Parse(genString);
    }

    public Consultar()
    {
        string selector = "";

        // Bucle que sigue pidiendo entrada hasta que el usuario ingrese un valor válido
        while (selector != "1" && selector != "2" && selector != "0")
        {
            Console.WriteLine("Quiere usar su propio autómata celular o probar el default?");
            Console.WriteLine(" 1) Introducir ruta");
            Console.WriteLine(" 2) Probar default");
            Console.WriteLine(" 0) Salir");

            selector = Console.ReadLine();

            // Mensaje de error si el valor ingresado no es correcto
            if (selector != "1" && selector != "2" && selector != "0")
            {
                Console.WriteLine("Ingrese un valor correcto: 1, 2 o 0.");
            }
        }
        if (selector == "1")
        {
            
        } else if (selector == "2")
        {
            
        }
        else
        {
            Console.WriteLine("Ingrese un valor correcto");
        }
        
    }
}