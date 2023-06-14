using DesignPatterns.Flyweight;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n Red Color Circles");
        for (int i = 0; i < 3; i++)
        {
            Circle circle = (Circle)ShapeFactory.GetShape("circle");
            circle.SetColor("Red");
            circle.Draw();
        }

        Console.WriteLine("\n Green Color Circles");
        for (int i = 0; i < 3; i++)
        {
            Circle circle = (Circle)ShapeFactory.GetShape("circle");
            circle.SetColor("Green");
            circle.Draw();
        }

        Console.WriteLine("\n Blue Color Circles");
        for (int i = 0; i < 3; i++)
        {
            Circle circle = (Circle)ShapeFactory.GetShape("circle");
            circle.SetColor("Blue");
            circle.Draw();
        }

        Console.WriteLine(ShapeFactory.GetCount());

        Console.ReadLine();
    }
}