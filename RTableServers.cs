using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class RTableServers
    {
        private List<string> servers = new List<string>();
        private int nextServer = 0;
        public RTableServers()
        {
            servers.Add("Arturs");
            servers.Add("Janis");
            servers.Add("Rob");
        }

        public string GetNextServer()
        {
            string output = servers[nextServer];
            nextServer++;
            //for constant rotation we add this
            if (nextServer >= servers.Count)
            {
                nextServer = 0;
            }
            return output;
        }

    }
}
