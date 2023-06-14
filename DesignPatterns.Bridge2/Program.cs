
using DesignPatterns.Bridge2;

public class Program
{
    private static void Main(string[] args)
    {
        Red redColor1 = new Red();
        Shape redCircle = new Circle(redColor1);
        redCircle.Draw();

        Console.WriteLine();

        Blue blueColor1 = new Blue();
        Shape blueCircle = new Circle(blueColor1);
        blueCircle.Draw();

        Console.WriteLine();

        Red redColor2 = new Red();
        Shape redSquare = new Square(redColor2);
        redSquare.Draw();

        Console.WriteLine();

        Blue blueColor2 = new Blue();
        Shape blueSquare = new Square(blueColor2);  
        blueSquare.Draw();
    }
}