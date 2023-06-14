using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite3
{
    public class Directory : IData
    {
        //composite
        private readonly IList<IData> children = new List<IData>(); 
        private readonly string directoryName;
        public string DirectoryName => directoryName;
        public Directory(string directoryName,int level)
        {
            string tab = "";
            for (int i = 0; i < level; i++)
            {
                tab += "\t";
            }
            this.directoryName = tab + directoryName;
        }

        public void AddChild(IData child)
        {
            children.Add(child);
        }
        public void RemoveChild(IData child)
        {
            children.Remove(child);
        }
        public IData GetChildren(int index)
        {
            if (index <0 || index > children.Count)
                throw new ArgumentOutOfRangeException($"index {index}");
            return children[index];
        }
        public void Print()
        {
            Console.WriteLine(directoryName);
            foreach (IData child in children)
            {
                child.Print();
            }
        }
    }
}
