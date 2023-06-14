using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class InternetProxy : IISP
    {
        public string GetResource(string site)
        {
            LogRequest(site);
            if (IsBlocked(site))
            {
                return "This site is blocked as per company policy";
            }
            NetworkSettings networkSettings = new NetworkSettings();
            return networkSettings.GetISP().GetResource(site);
        }
        private void LogRequest(string site)
        {
            Console.WriteLine(DateTime.Now + " Request for: " + site);
        }
        private bool IsBlocked(string site)
        {
            switch (site)
            {
                case "www.google.com":
                return false;
                case "www.test.com":
                    return true;
                default:
                    return true;
            }
        }
    }
}