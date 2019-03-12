using System;
using System.Net;

namespace Socket
{
    class DomainName
    {
        static void Main(string[] args)
        {
            IPHostEntry host1 = Dns.GetHostEntry("www.microsoft.com");
            foreach (IPAddress ip in host1.AddressList)
            {
                Console.WriteLine(ip.ToString());
            }
            IPHostEntry host2 = Dns.GetHostEntry("91.120.22.150");
            Console.WriteLine(host2.HostName);
        }
    }
}
