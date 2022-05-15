using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public Transform End1, End2;
    public float speed;
    public Transform startPos;
    Vector3 NextPos;
    
    void Start()
    {
        NextPos = startPos.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position == End1.position)
        {
            NextPos = End2.position;
        }
        if (transform.position == End2.position)
        {
            NextPos = End1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, NextPos, speed * Time.deltaTime);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(End1.position, End2.position);
    }
}
