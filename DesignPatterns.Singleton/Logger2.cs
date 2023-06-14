using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class Logger2
    {
        private static Logger2 instance;
        private Logger2()
        {

        }
        public static Logger2 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger2();
                }
                return instance;
            }
        }
    }
}
