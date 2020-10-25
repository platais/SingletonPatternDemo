using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class RTableServers
    {
        //readonly mens you cant overwrite _instance with something else, once
        //its assigned it cant be reassigned by new value
        //static - you can access _instance without class being extensiated(but now its private)
        //we create instance of this class only we start uzing it, kind of "lazy instantiation"
        //everyone gets the same instance
        private static readonly RTableServers _instance = new RTableServers();
        private List<string> servers = new List<string>();
        private int nextServer = 0;
        private RTableServers()
        {
            servers.Add("Arturs");
            servers.Add("Janis");
            servers.Add("Rob");
        }

        public static RTableServers GetRTableServers() 
        {
            return _instance;
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
