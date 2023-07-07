using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
public class CreateAndJoin : MonoBehaviourPunCallbacks
{
    public TMP_InputField Create, Join;
    void Start()
    {
        
    }
    
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(Create.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(Join.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
