using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGuide : MonoBehaviour
{
    public Transform player;
    public Transform AIGuideTransform;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 temp = transform.position;
        temp.x = AIGuideTransform.position.x;
        temp.y = AIGuideTransform.position.y;
        transform.position = temp;

    }
}
