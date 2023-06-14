using DesignPatterns.Factory2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please Enter : Toyota | BMW | Ferrari");
        string type = Console.ReadLine();

        CarFactory carFactory = new CarFactory();
        ICar car = carFactory.GetCar(type);

        car.Start();

    }
}