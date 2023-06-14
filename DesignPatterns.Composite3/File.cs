using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite3
{
    //Leaf
    public class File : IData
    {
        private readonly string fileName;
        public File(string fileName,int level)
        {
            string tab = "";
            for (int i = 0; i < level; i++)
            {
                tab += "\t";
            }
            this.fileName = tab + fileName;
        }

        public string FileName => fileName;

        public void Print()
        {
            Console.WriteLine(fileName);
        }
    }
}
