using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Cinemachine;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject player;
    public GameObject otherDuck;
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        GameObject spawned = PhotonNetwork.Instantiate(player.name, Vector3.zero, Quaternion.identity);
        spawned.GetComponentInChildren<CinemachineVirtualCamera>().enabled = true;
        for (int i = 2; i > 0; i--) {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-3f, 3f);
            PhotonNetwork.Instantiate(otherDuck.name, new Vector3(x, y, 0f), Quaternion.identity);

        }
        for (int i = 8; i > 0; i--) {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-3f, 3f);
            PhotonNetwork.Instantiate(coin.name, new Vector3(x, y, 0f), Quaternion.identity);
        }
    }

}
