using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;

    public float time = .1f;
    public int damage = 50;
    public float radius = 2.5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Launcher"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            CameraShaker.Instance.ShakeOnce(10f, 10f, 0.2f, 2f);
            FindObjectOfType<AudioController>().Play("Explode", 1);
            GameObject explosionInScene = GameObject.FindGameObjectWithTag("Explosion");
            Destroy(explosionInScene, time);
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);

            foreach (Collider2D nearbyObject in colliders)
            {
                Rigidbody2D rb = nearbyObject.GetComponent<Rigidbody2D>();
                if (rb != null)
                {

                    Hurt hurt = nearbyObject.GetComponent<Hurt>();
                    PlayerHealth playerHealth = nearbyObject.GetComponent<PlayerHealth>();
                    if (hurt != null)
                    {
                        hurt.takeDamage(damage);
                    }
                    if (playerHealth != null)
                    {
                        playerHealth.takeDamage(damage);
                    }

                }

            }

            Destroy(gameObject);

        }
        else
        {
            return;
        }
        if (!collision.CompareTag("Lava"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            CameraShaker.Instance.ShakeOnce(10f, 10f, 0.2f, 2f);
            FindObjectOfType<AudioController>().Play("Explode", 1);
            GameObject explosionInScene = GameObject.FindGameObjectWithTag("Explosion");
            Destroy(explosionInScene, time);
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);

            foreach (Collider2D nearbyObject in colliders)
            {
                Rigidbody2D rb = nearbyObject.GetComponent<Rigidbody2D>();
                if (rb != null)
                {

                    Hurt hurt = nearbyObject.GetComponent<Hurt>();
                    PlayerHealth playerHealth = nearbyObject.GetComponent<PlayerHealth>();
                    if (hurt != null)
                    {
                        hurt.takeDamage(damage);
                    }
                    if (playerHealth != null)
                    {
                        playerHealth.takeDamage(damage);
                    }

                }

            }

            Destroy(gameObject);

        }
        else
        {
            return;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
