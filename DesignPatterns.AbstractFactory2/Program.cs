using DesignPatterns.AbstractFactory2;

public enum FurnitureType
{
    ART = 10,
    VICTORIAN = 20
}

public class Program
{
    private static void Main(string[] args)
    {
        FurnitureAbstractFactory furnitureAbstractFactory = FactoryProvider.GetFactory(FurnitureType.VICTORIAN);

        IChair objChair = furnitureAbstractFactory.CreateChair();
        objChair.SitOn();

        ISofa objSofa = furnitureAbstractFactory.CreateSofa();
        objSofa.SitOn();

        ICoffeeTable objCoffeeTable = furnitureAbstractFactory.CreateCoffeeTable();
        objCoffeeTable.DrinkCoffee();
    }
}