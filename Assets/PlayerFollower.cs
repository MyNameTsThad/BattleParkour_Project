using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public Transform player;
    public Transform CameraMiniMap;
    void Start()
    {
        gameObject.transform.position = player.position = CameraMiniMap.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = player.position = CameraMiniMap.position;
    }
}
