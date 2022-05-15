using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPos : MonoBehaviour
{
    public Transform end1, end2;
    public float y;
    void Start()
    {
        transform.position = new Vector3(Random.Range(end1.position.x, end2.position.x), y, 0);
    }

    
}
