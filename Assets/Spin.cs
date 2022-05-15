using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speedRotate = 10;
    private void FixedUpdate()
    {
        StartCoroutine(ToggleSpin());
    }
    public IEnumerator ToggleSpin()
    {

        transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime);
        yield return null;
    }
}
