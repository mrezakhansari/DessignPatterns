using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();
        private List<string> _servers = new List<string>();
        private int nextServer = 0;
        private TableServers()
        {
            _servers.Add("Reza");
            _servers.Add("Ahmad");
            _servers.Add("Gholam");
            _servers.Add("Naghi");
        }
        public static TableServers GetTableServers()
        {
            return _instance;
        }
        public string NextServer()
        {
            string output = _servers[nextServer];
            nextServer++;
            if (nextServer >= _servers.Count)
            {
                nextServer = 0;
            }
            return output;
        }
    }
}
