using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;


public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public TMP_InputField create;
    public TMP_InputField join;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CreateRoom() {
        PhotonNetwork.CreateRoom(create.text);
    }

    public void JoinRoom() {
        PhotonNetwork.JoinRoom(join.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("SampleScene");
    }


}
