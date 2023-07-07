using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        PhotonNetwork.Instantiate(player.name, new Vector2(0, 0), Quaternion.identity);
    }

}
