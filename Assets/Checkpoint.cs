using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private CheckPointController checkPoint;

    public Transform pos;

    private void Start()
    {
        checkPoint = GameObject.FindGameObjectWithTag("CheckPointController").GetComponent<CheckPointController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            checkPoint.lastCheckPointPos = pos.position;
        }
    }
}
