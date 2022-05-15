using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze_PowerUp : MonoBehaviour
{
    
    public float multiplier = 2;
    public float duration = 15f;
    public GameObject explosion;
    GameObject FreezeEffect;
    TimerManager timerManager;

    private void Start()
    {
        
        FreezeEffect = GameObject.FindGameObjectWithTag("FreezeEffect");
        timerManager = GameObject.FindGameObjectWithTag("Timer").GetComponent<TimerManager>();
        
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
 
        FindObjectOfType<AudioController>().Play("PowerUp", 1);

        GetComponent<SpriteRenderer>().enabled = false;

        GetComponent<PolygonCollider2D>().enabled = false;

        Instantiate(explosion, transform.position, transform.rotation);

        FreezeEffect.SetActive(true);
        timerManager.SlowMotion();
        

        yield return new WaitForSeconds(duration);
        FreezeEffect.SetActive(false);
        
        Destroy(gameObject);
    }
}
