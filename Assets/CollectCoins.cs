using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private CoinCount coin;
    private void Start()
    {
        coin = GameObject.FindGameObjectWithTag("GameController").GetComponent<CoinCount>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<AudioController>().Play("PickUp", 1);
            coin.AddAndSetCoins(1);
            Destroy(gameObject);
        }
    }
}
