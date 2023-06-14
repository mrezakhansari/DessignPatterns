using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class Vodafone : IISP
    {
        public string GetResource(string site)
        {
            switch (site)
            {
                case "www.google.com":
                    return "Google Site";
                case "www.yahoo.com":
                    return "Yahoo Site";
                default:
                    return "Sorry! no resource found";
            }
        }
    }
}