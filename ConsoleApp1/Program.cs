using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Linear linear = new(1, 2);
        Console.WriteLine(linear.getSquare());

        Square square = new(1, 0, 1);
        Console.WriteLine(square.getSquare());
    }
}