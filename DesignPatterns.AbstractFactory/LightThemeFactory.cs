using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class LightThemeFactory : ThemeAbstractFactory
    {
        public IDialog GetDialog()
        {
            IDialog lightDialog = new LightDialog();
            return lightDialog;
        }

        public IToolbar GetToolbar()
        {
            IToolbar lightToolbar = new LightToolbar();
            return lightToolbar;
        }
    }
}