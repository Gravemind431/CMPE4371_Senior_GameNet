using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photon.SocketServer;
using PhotonHostRuntimeInterfaces;
using ExitGames.Logging;
using ExitGames.Logging.Log4Net;
using log4net.Config;

public class NoiresPeer : ClientPeer
{
    public NoiresPeer(InitRequest initRequest) : base(initRequest)
    {

    }

    /*public NoiresPeer(IRpcProtocol protocol, IPhotonPeer unmanagedPeer) : base(protocol, unmanagedPeer)
    {

    }*/

    protected override void OnDisconnect(DisconnectReason reasonCode, string reasonDetail)
    {

    }

    protected override void OnOperationRequest(OperationRequest operationRequest, SendParameters sendParameters)
    {

    }
}