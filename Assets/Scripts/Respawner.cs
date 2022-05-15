using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField] Transform SpawnPoint;
    public GameObject player;
    public void Respawn()
    {
        player.transform.position = SpawnPoint.position;

    }

}
