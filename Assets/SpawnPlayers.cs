using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Cinemachine;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject player;
    public GameObject otherDuck;

    // Start is called before the first frame update
    void Start()
    {
        GameObject spawned = PhotonNetwork.Instantiate(player.name, Vector3.zero, Quaternion.identity);
        spawned.GetComponentInChildren<CinemachineVirtualCamera>().enabled = true;
        PhotonNetwork.Instantiate(otherDuck.name, Vector3.zero, Quaternion.identity);
    }

}
