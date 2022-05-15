using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffExplosion : MonoBehaviour
{
    public GameObject explosion;
    public void Explode()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
