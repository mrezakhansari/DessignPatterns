
using DesignPatterns.Factory;

internal class Program
{
    private static void Main(string[] args)
    {
        // een yek ghanoon ast.
        //superClass obj = new subClass();
        Console.WriteLine("Enter Rectangle or Square or Circle:");
        string type = Console.ReadLine();

        // masooliate gereftan e object ro mizarim rooye gardane shapeFactory
        // agar class e jadidi be shape ha ezafe beshe kafie ke tooye method
        // getshape taghir kone
        ShapeFactory shapeFactory = new ShapeFactory();
        IShape shape1 =  shapeFactory.GetShape(type);
        shape1.Draw();

    }
    public void M1()
    {
        Console.WriteLine("Enter Rectangle or Square or Circle:");
        string type = Console.ReadLine();

        // masooliate gereftan e object ro mizarim rooye gardane shapeFactory
        ShapeFactory shapeFactory = new ShapeFactory();
        IShape shape1 = shapeFactory.GetShape(type);
        shape1.Draw();
    }

    public void M2()
    {
        Console.WriteLine("Enter Rectangle or Square or Circle:");
        string type = Console.ReadLine();

        // masooliate gereftan e object ro mizarim rooye gardane shapeFactory
        
        ShapeFactory shapeFactory = new ShapeFactory();
        IShape shape1 = shapeFactory.GetShape(type);
        shape1.Draw();
    }
}