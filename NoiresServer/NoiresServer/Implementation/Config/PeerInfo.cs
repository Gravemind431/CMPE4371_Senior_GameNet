using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NoiresServer.Implementation.Config
{
    public class PeerInfo 
    {
        public IPEndPoint MasterEndPoint { get; set; }
        public int ConnectRetryIntervalSeconds { get; set; }

        public bool IsSibilingConnection { get; set; }
        public int MaxTries { get; set; }
        public int NumTries { get; set; }

        public PeerInfo(string ipAddress, int ipPort, int connectRetryIntervalSeconds, bool issiblingConnection, int maxTries)
        {
            MasterEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress) , ipPort);
            ConnectRetryIntervalSeconds = connectRetryIntervalSeconds;
            IsSibilingConnection = issiblingConnection;
            MaxTries = maxTries;
            NumTries = 0;
        }
    }
}
