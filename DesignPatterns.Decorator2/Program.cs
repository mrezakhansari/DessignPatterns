using DesignPatterns.Decorator2;

public class Program
{
    private static void Main(string[] args)
    {
        IFlightSeat mainCabinSeat = new WiFi(new LiveTV(new MainCabinSeat()));

        Console.WriteLine("Chossen Facilities for your seat");
        Console.WriteLine(mainCabinSeat.GetFacilities());
        Console.WriteLine("Total Cost:" + mainCabinSeat.GetPrice());


        Console.ReadLine();
    }
}