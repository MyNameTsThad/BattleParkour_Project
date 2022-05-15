using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    private CheckPointController checkPoint;
    void Start()
    {
        checkPoint = GameObject.FindGameObjectWithTag("CheckPointController").GetComponent<CheckPointController>();
        transform.position = checkPoint.lastCheckPointPos;
    }

   
}
