using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class FactoryProvider
    {
        public static ThemeAbstractFactory GetFactory(Theme theme)
        {
            ThemeAbstractFactory themeAbstractFactory = null;
            switch (theme)
            {
                case Theme.Light:
                    themeAbstractFactory = new LightThemeFactory();
                    break;
                case Theme.Dark:
                    themeAbstractFactory = new DarkThemeFactory();
                    break;
                default:
                    break;
            }
            return themeAbstractFactory;
        }
    }
}