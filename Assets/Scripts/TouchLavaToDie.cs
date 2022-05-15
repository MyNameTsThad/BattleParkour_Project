using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchLavaToDie : MonoBehaviour
{

    public GameManager manager;
    public GameObject explosion;
    public GameObject HealthBar;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {

        

        if (collision.gameObject.CompareTag("Lava"))
        {
            FindObjectOfType<AudioController>().Play("Explode", 1);
            manager.EndGame();
            HealthBar.GetComponent<HealthBarController>().SetHealth(0f);
            Instantiate(explosion, transform.position, transform.rotation = Quaternion.identity);
            gameObject.SetActive(false);
            
            
            gameObject.tag = "Dead";
            
            
        }
    }
}
