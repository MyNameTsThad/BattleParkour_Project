using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class TouchLavaToDespawn : MonoBehaviour
{
    public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            FindObjectOfType<AudioController>().Play("Explode", 1);
            Instantiate(explosion, transform.position, transform.rotation = Quaternion.identity);
            Destroy(gameObject);
            CameraShaker.Instance.ShakeOnce(2f, 2f, 0.1f, 1f);
        }
    }
}
