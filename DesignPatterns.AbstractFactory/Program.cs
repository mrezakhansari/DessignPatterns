
using DesignPatterns.AbstractFactory;

public enum Theme
{
    Light = 1,
    Dark = 2
}

public class Program
{
    private static void Main(string[] args)
    {
        ThemeAbstractFactory themeAbstractFactory = FactoryProvider.GetFactory(Theme.Dark);

        IToolbar toolbar1 = themeAbstractFactory.GetToolbar();
        toolbar1.ShowToolbar();

        IDialog dialog1= themeAbstractFactory.GetDialog();
        dialog1.ShowDialog();

        Console.ReadLine();
    }
}