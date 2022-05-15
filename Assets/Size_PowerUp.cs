using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size_PowerUp : MonoBehaviour
{
    GameObject player;
    public float multiplier = 1.5f;
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
            StartCoroutine(PickUp_Size());
        }
    }
    IEnumerator PickUp_Size()
    {
        
        player.transform.localScale *= multiplier;
        FindObjectOfType<AudioController>().Play("PowerUp", 1);

        GetComponent<SpriteRenderer>().enabled = false;

        GetComponent<PolygonCollider2D>().enabled = false;

        Instantiate(explosion, transform.position, transform.rotation);

        LightShow.GetComponent<LightsManager>().Showlights(1, true);

        yield return new WaitForSeconds(duration);
        LightShow.GetComponent<LightsManager>().Showlights(1, false);
        player.transform.localScale /= multiplier;
        Destroy(gameObject);
    }

}