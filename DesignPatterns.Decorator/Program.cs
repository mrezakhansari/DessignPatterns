using DesignPatterns.Decorator;

public class Program
{
    private static void Main(string[] args)
    {
        Beverage beverage1 = new DarkRoast();
        Console.WriteLine(beverage1.Description);
        Console.WriteLine($" ${beverage1.Cost()}");

        Beverage beverage2 = new Mocha(new Mocha(new Whip(new DarkRoast())));
        Console.WriteLine(beverage2.Description);
        Console.WriteLine($" ${beverage2.Cost()}");

        Console.ReadLine();
    }
}