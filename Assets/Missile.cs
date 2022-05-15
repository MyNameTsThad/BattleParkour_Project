using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

[RequireComponent(typeof(Rigidbody2D))]
public class Missile : MonoBehaviour
{
    Transform target;
    private Rigidbody2D rb;

    public float speed = 5f;
    public float rotSpeed = 200f;
    public float time = .1f;
    public int damage = 50;
    public float radius;

    public GameObject explosion;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();
        float rotAmmount = Vector3.Cross(direction, transform.right).z;

        rb.angularVelocity = -rotAmmount * rotSpeed;
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
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
