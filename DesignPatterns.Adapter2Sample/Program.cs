

using DesignPatterns.Adapter2ClassLibrary;
using DesignPatterns.Adapter2Sample;

public class Program
{
    private static void Main(string[] args)
    {
        // eenja mikhahim az class library adapter2classlibrary estefadeh konim
        // eenja class MovableAdapter yek vaset hast beyne adapter2classlibrary va program(client)
        Movable bugattiVeyron = new BugattiVeyron();
        MovableAdapter bugattiVeyronAdapter = new MovableAdapter(bugattiVeyron);
        Console.WriteLine("Bugatti Veyron Super's top speed is " + bugattiVeyronAdapter.GetSpeed() + " Kmph.");

        Movable mcLaren = new McLaren();
        MovableAdapter mcLarenAdapter = new MovableAdapter(mcLaren);
        Console.WriteLine("McLaren Super's top speed is " + mcLarenAdapter.GetSpeed() + " Kmph.");

        Movable astonMartin = new AstonMartin();
        MovableAdapter astonMartinAdapter = new MovableAdapter(astonMartin);
        Console.WriteLine("Aston Martin Super's top speed is " + astonMartinAdapter.GetSpeed() + " Kmph.");
    }
}