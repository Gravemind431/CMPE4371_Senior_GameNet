using ExitGames.Client.Photon;
using System;

public class EngineState
{
    //public static EngineState DisconnectedState = new EngineState() { OnUpdate = () => { }, sendRequest = (r, s, c, e) => { } };
    public static EngineState DisconnectedState = new EngineState() { OnUpdate = DoUpdate, sendRequest = DoSend };
    public static EngineState WaitingToConnectState = new EngineState() { OnUpdate = DoUpdate, sendRequest = DoSend };
    public static EngineState ConnectingState = new EngineState() { OnUpdate = DoUpdate, sendRequest = DoSend };
    public static EngineState ConnectedState = new EngineState() { OnUpdate = DoUpdate, sendRequest = DoSend };
    public Action OnUpdate { get; set; }
    public Action<OperationRequest, bool, byte, bool> sendRequest { get; set; }

    protected EngineState() { }

    protected static void DoUpdate()
    {
        NewNet.instance.Peer.Service();
    }

    protected static void DoSend(OperationRequest request, bool sendReliable, byte channelId, bool encrypt)
    {
        NewNet.instance.Peer.OpCustom(request, sendReliable, channelId, encrypt);
    }
}

