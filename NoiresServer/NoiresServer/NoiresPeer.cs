using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photon.SocketServer;
using PhotonHostRuntimeInterfaces;

namespace NoiresServer
{
    class NoiresPeer : ClientPeer
    {
        public NoiresPeer(InitRequest initRequest) : base(initRequest)
        {
        }

        protected override void OnDisconnect(DisconnectReason reasonCode, string reasonDetail)
        {
            throw new NotImplementedException();
        }

        protected override void OnOperationRequest(OperationRequest operationRequest, SendParameters sendParameters)
        {
            throw new NotImplementedException();
        }
    }
}
