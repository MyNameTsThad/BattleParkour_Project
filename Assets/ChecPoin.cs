using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChecPoin : MonoBehaviour
{
    private static ChecPoin instance;
    public Vector2 lastCheckpointPos;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }else if (instance != null)
        {   
            DontDestroyOnLoad(instance);
            Destroy(gameObject);
        }

        
    }
}
