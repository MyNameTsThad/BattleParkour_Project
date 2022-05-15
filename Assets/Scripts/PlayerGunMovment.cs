using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunMovment : MonoBehaviour
{

    public GameObject myPlayer;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 diffrence = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diffrence.Normalize();
        float rotZ = Mathf.Atan2(diffrence.y, diffrence.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
    }

}
