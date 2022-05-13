using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._3___Singleton
{
    internal sealed class LoadBalancer
    {

        private static readonly LoadBalancer Instance = new LoadBalancer();

        private static List<Server> _servers;
        private readonly Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server { Name = "ServerI", IP= "1"  },
                new Server { Name = "ServerII", IP= "2"  },
                new Server { Name = "ServerIII", IP= "3"  },
                new Server { Name = "ServerIV", IP= "4"  },
                new Server { Name = "ServerV", IP= "5"  },
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
