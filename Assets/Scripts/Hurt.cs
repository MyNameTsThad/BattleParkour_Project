using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Hurt : MonoBehaviour
{
    
    public int health = 100;
    public HealthBarController controller;
    public GameObject explosion;
    public GameObject coin;
    public Points points;

    private void Start()
    {
        points = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<Points>();
        controller.SetMaxHealth(health);
    }
    private void Update()
    {
        controller.SetHealth(health);
    }


    public void takeDamage(int damage)
    {
        health -= damage;
        controller.SetHealth(health);
        FindObjectOfType<AudioController>().Play("Hit", 1);
        if (health <= 0 )
        {
            Die();
        }
    }
    public void Die()
    {
        GameObject e = (GameObject)Instantiate(explosion);
        e.transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
        
        Destroy(gameObject);
        FindObjectOfType<AudioController>().Play("Explode", 1);
        Instantiate(coin, transform.position, transform.rotation = Quaternion.identity);
        points.AddPoints(5);
        CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 1f);
        if (gameObject.tag == "Spawners")
        {
            Instantiate(coin, transform.position, transform.rotation = Quaternion.identity);
            Instantiate(coin, transform.position, transform.rotation = Quaternion.identity);
            points.AddPoints(10);
            CameraShaker.Instance.ShakeOnce(8f, 8f, 0.1f, 1f);
        }


    }
    
}
