using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class Browser
    {
        public void SendRequest()
        {
            Console.WriteLine("Enter the site URL");
            string site = Console.ReadLine();
            string response = GetInternetProvider().GetResource(site);
            LoadResponse(response);
        }
        //print the output from isp
        private void LoadResponse(string response)
        {
            Console.WriteLine(response);
        }
        //get the network setting for isp to use
        private IISP GetInternetProvider()
        {
            return new NetworkSettings().GetInternet();
        }
    }
}