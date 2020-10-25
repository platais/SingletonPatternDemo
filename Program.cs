using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static RTableServers host1List = new RTableServers();
        static RTableServers host2List = new RTableServers();
        static void Main(string[] args)
        {
            RTableServers servers = new RTableServers();

            //10 total table servers we will ask for
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine($"The next server is: {servers.GetNextServer()}");
                Host1GenNexServer();
                Host2GenNexServer();
            }
            Console.ReadKey();
        }
        private static void Host1GenNexServer() 
        {
            Console.WriteLine($"The next h1 server is: {host1List.GetNextServer()}");
        }
        private static void Host2GenNexServer()
        {
            Console.WriteLine($"The next h2 server is: {host2List.GetNextServer()}");
        }
    }
}
