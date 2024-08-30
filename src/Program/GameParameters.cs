namespace Ucu.Poo.GameOfLife;

public class GameParameters
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

    public GameParameters()
    {
        path = @"C:\Repos\Game-of-Life\assets\board.txt";
        generations = 73;
    }
}