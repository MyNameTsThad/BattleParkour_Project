using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public GameManager Manager;
    public float firstHealth = 100;
    public float health = 100;
    public float currentHealth;
    public HealthBarController healthBar;
    public GameObject explosion;
    public void Start()
    {
        health = firstHealth;
        currentHealth = health;
        healthBar.SetMaxHealth(health);
    }
    private void Update()
    {
        healthBar.SetHealth(health);
    }
    public void takeDamage(int damage)
    {
        health -= damage;
        healthBar.SetHealth(health);
        FindObjectOfType<AudioController>().Play("Hit", 1);
        if (health <= 0)
        {
            Die();
        }
        
    }
    public void Die()
    {
        GameObject e = (GameObject)Instantiate(explosion);
        e.transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
        Manager.EndGame();
        healthBar.GetComponent<HealthBarController>().SetHealth(0f);
        gameObject.tag = "Dead";
        gameObject.SetActive(false);

    }
     
}
