using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_PowerUp : MonoBehaviour
{
    GameObject player;
    public float multiplier = 2;
    public float duration = 15f;
    public GameObject explosion;
    GameObject LightShow;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        LightShow = GameObject.FindGameObjectWithTag("Lights");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(PickUp_Health());
        }
    }
    IEnumerator PickUp_Health()
    {
       PlayerHealth health = player.GetComponent<PlayerHealth>();
        health.health *= multiplier;
        health.currentHealth += health.health - health.firstHealth;
        FindObjectOfType<AudioController>().Play("PowerUp", 1);

        GetComponent<SpriteRenderer>().enabled = false;

        GetComponent<PolygonCollider2D>().enabled = false;

        Instantiate(explosion, transform.position, transform.rotation);

        LightShow.GetComponent<LightsManager>().Showlights(0, true);


        yield return new WaitForSeconds(duration);
        LightShow.GetComponent<LightsManager>().Showlights(0, false);
        health.currentHealth /= multiplier;
        health.health -= health.health - health.firstHealth;
        Destroy(gameObject);
    }

}
