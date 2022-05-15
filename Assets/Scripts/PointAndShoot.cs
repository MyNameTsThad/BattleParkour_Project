using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    private Vector3 target;
    public GameObject crosshairs;
    public GameObject player;
    public GameObject bulletPrefab;
    public float bulletSpeed = 60.0f;
    public GameObject StartPos;
   

    public void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, transform.position.z));
            target.z = 0f;
        }
        
        crosshairs.transform.position = new Vector2(target.x, target.y);
        Vector3 diffrence = target - player.transform.position;
        float rotZ = Mathf.Atan2(diffrence.y, diffrence.x) * Mathf.Rad2Deg;
        player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotZ);
        if (Input.GetMouseButtonDown(0))
        {
            float distance = diffrence.magnitude;
            Vector2 direction = diffrence / distance;
            direction.Normalize();
            
            
            fireBullet(direction, rotZ);
            

        }
        
    }
    void fireBullet(Vector2 direction, float RotationZ)
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = StartPos.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, RotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        FindObjectOfType<AudioController>().Play("Shoot", 1);
    }
}
