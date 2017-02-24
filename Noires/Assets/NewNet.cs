using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExitGames.Client.Photon;
using System;
using Hashtable = ExitGames.Client.Photon.Hashtable;

public class NewNet : MonoBehaviour, IPhotonPeerListener
{
    public static NewNet instance = null;
    public EngineState State { get; protected set; }
    public PhotonPeer Peer {get; set; }
    public int ping { get; protected set; }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        Initialize();
    }

    protected void Initialize()
    {
        State = EngineState.DisconnectedState;
        Application.runInBackground = true;

        //Create Peer
        Peer = new PhotonPeer(this, ConnectionProtocol.Udp);
        ConnectToServer("192.168.0.13:5055", "NoiresApplication");
    }

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Disconnect();
            Application.Quit();
        }
    }
    void FixedUpdate()
    {
        ping = Peer.RoundTripTime;

        State.OnUpdate();      
    }

    public void Disconnect()
    {
        if( Peer != null && Peer.PeerState == PeerStateValue.Connected)
        {
            Peer.Disconnect();
        }
        State = EngineState.DisconnectedState;
    }

    public void ConnectToServer(string serverAddress, string applicationName)
    {
        if(State == EngineState.DisconnectedState)
        {
            Peer.Connect(serverAddress, applicationName);
            State = EngineState.WaitingToConnectState;
        }
        
        
    }
    public void DebugReturn(DebugLevel level, string message)
    {
        //throw new NotImplementedException();
    }

    public void OnEvent(EventData eventData)
    {
        //throw new NotImplementedException();
    }

    public void OnStatusChanged(StatusCode statusCode)
    {
        //throw new NotImplementedException();
        Debug.Log("Status Code: " + statusCode);
        Debug.Log("Peer State: " + Peer.PeerState);
    }

    public void OnOperationResponse(OperationResponse operationResponse)
    {
        switch (operationResponse.OperationCode)
        {
            case OpCodes.GAME_INIT:
                GameStart(operationResponse.Parameters);
                break;

        }
    }

    private void GameStart(Dictionary<byte, object> parameters)
    {

        //throw new NotImplementedException();
    }
}
