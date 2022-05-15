using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hurt enemy = collision.GetComponent<Hurt>();
        Instantiate(explosion, transform.position, transform.rotation = Quaternion.identity);
        if (enemy != null)
        {
            enemy.takeDamage(30);
        }
        
        Destroy(gameObject);
    }
}
