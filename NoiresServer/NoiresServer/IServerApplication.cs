using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoiresServer.Implementation.Config;

namespace NoiresServer
{
    public interface IServerApplication
    {
        byte SubCodeParameterCode { get;  }
        string BinaryPath { get; }
        string ApplicationName { get; }


        void Setup();
        void TearDown();
        void OnServerConnectionFailed(int errorCode, string errorMessage, object state);
        void AfterServerRegistration(IServerPeer serverPeer);
        void ConnectToPeer(PeerInfo peerInfo);
    }
}
