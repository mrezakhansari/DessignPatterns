using DesignPatterns.Builder;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("----- Concrete House -----");

        HouseBuilder concreteHouseBuilder = new ConcreteHouseBuilder();
        ConstructionEngineer engineerA = new ConstructionEngineer(concreteHouseBuilder);

        House houseA = engineerA.ConstructHouse();
        Console.WriteLine("House is: " + houseA);

        Console.WriteLine("\n----- Prefabricated House -----");

        PrefabricatedHouseBuilder prefabricatedHouseBuilder = new PrefabricatedHouseBuilder();
        ConstructionEngineer engineerB = new ConstructionEngineer(prefabricatedHouseBuilder);

        House houseB = engineerB.ConstructHouse();
        Console.WriteLine("House is: " + houseB);
    }
}