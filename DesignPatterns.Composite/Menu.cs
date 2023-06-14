using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite
{
    public class Menu : IMenuComponent
    {
        private readonly IList<IMenuComponent> menuComponents = new List<IMenuComponent>();
        private readonly string name;
        private readonly string description;

        public string Name => name;
        public string Description => description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void Add(IMenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }
        public void Remove(IMenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }
        public IMenuComponent GetChild(int index)
        {
            return (IMenuComponent)menuComponents[index];
        }
        public string Show()
        {
            string menuDisplay = GetMenuComponentInfo();
            for (int i = 0; i < menuComponents.Count; i++)
            {
                IMenuComponent menuComponent = (IMenuComponent)menuComponents[i];
                menuDisplay += "\n" + menuComponent.Show();
            }
            return menuDisplay;
        }

        public string GetMenuComponentInfo()
        {
            return Name + "\t" + Description;
        }




    }
}