using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{

    private int coinCount = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("hi2");
        if (collision.transform.CompareTag("Coin"))
        {
            coinCount++;
            PhotonNetwork.Destroy(collision.gameObject);
        }
    }
}
