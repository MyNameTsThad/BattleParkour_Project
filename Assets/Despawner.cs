using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    public float timeBeforeDespawn = 30f;
    public void Start()
    {
        Destroy(gameObject, timeBeforeDespawn);
    }
}
