using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class NetworkSettings
    {
        public IISP GetInternet()
        {
            return new InternetProxy();
        }
        public IISP GetISP()
        {
            return new Vodafone();
        }
    }
}