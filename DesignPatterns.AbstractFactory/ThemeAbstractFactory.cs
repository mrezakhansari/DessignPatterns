using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public interface ThemeAbstractFactory
    {
        IDialog GetDialog();
        IToolbar GetToolbar();
    }
}