using DesignPatterns.Composite;

public class Program
{
    private static void Main(string[] args)
    {
        Menu menu = new Menu("Burgers", "Burgers Description");
        menu.Add(new MenuItem("Burger", "Burger Description", false, 1.50));
        menu.Add(new MenuItem("Cheese Burger", "Cheese Burger Description", false, 1.50));
        menu.Add(new MenuItem("Chicken Burger", "Chicken Burger Description", false, 1.50));

        menu.Add(new Menu("Delicious Grill Specials", "Delicious Grill Specials Description"));
        menu.Add(new MenuItem("Sirloin Steak", "Sirloin Steak Description", false, 6.50));

        menu.Add(new Menu("Vegetarian Dishes", "Vegetarian Dishes Description"));
        menu.Add(new MenuItem("Pasta Salad", "Pasta Salad Description", true, 7));
        menu.Add(new MenuItem("Pepper Ptatoes", "Pepper Ptatoes Description", true, 7));

        string showMenu = menu.Show();
        Console.WriteLine(showMenu);
        Console.ReadLine();
    }
}