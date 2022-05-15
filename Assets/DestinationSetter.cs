using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationSetter : MonoBehaviour
{
    public AIDestinationSetter destinationSetter;
    public string tagToGo;
    private void Start()
    {
        destinationSetter.target = GameObject.FindGameObjectWithTag(tagToGo).transform;
    }
}
