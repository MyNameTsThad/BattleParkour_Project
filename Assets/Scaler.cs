using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    public float scaleSmall;
    public float scaleBig;

    public Vector3 nextScaleValue;
    public float scaleSpeed;
    public float defaultY = 0.382f;
    public float defaultZ = 1f;

    private void Start()
    {
        transform.localScale = new Vector3(Random.Range(scaleSmall, scaleBig), defaultY, defaultZ);
    }
    private void FixedUpdate()
    {
        if (transform.localScale == new Vector3(scaleSmall, defaultY, defaultZ))
        {
            nextScaleValue = new Vector3(scaleSmall, defaultY, defaultZ);
        }
        if (transform.localScale == new Vector3(scaleBig, defaultY, defaultZ))
        {
            nextScaleValue = new Vector3(scaleBig, defaultY, defaultZ);
        }
    }
}
