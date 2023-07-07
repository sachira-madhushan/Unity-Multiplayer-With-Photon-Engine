using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Player : MonoBehaviour
{
    private PhotonView photonView;
    private void Start()
    {
        photonView = GetComponent<PhotonView>();
    }
    void Update()
    {


        if (photonView.IsMine)
        {
            float x = Input.GetAxis("Horizontal");
            transform.position = new Vector3(transform.position.x + x*0.1f*Time.timeScale, transform.position.y);
        }
    }
}
