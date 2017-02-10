using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExitGames.Client.Photon.LoadBalancing;

public class NewNet : LoadBalancingClient {

	public void CallConnect()
    {
        MasterServerAddress = "127.0.0.1";
        bool couldConnect = false;

        couldConnect = Connect();

        if (!couldConnect)
        {
            Debug.Log("<color=red>Fatal error:</color> Could not connect to server!");
            this.DebugReturn(ExitGames.Client.Photon.DebugLevel.ERROR, "Can't Connect to: " + this.CurrentServerAddress);
        }
        MyCreateRoom("First_Room", 4);
    }
	
	// Update is called once per frame
	void Update () {
        Service();
	}

    void OnApplicationQuit()
    {
        Disconnect();
    }

    void MyCreateRoom(string roomName, byte maxPlayers)
    {
        this.OpJoinOrCreateRoom(roomName, new RoomOptions() { MaxPlayers = maxPlayers }, TypedLobby.Default);
    }
}
