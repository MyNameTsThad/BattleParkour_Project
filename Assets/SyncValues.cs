using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.UI;

public class SyncValues : MonoBehaviour
{
    public Slider valueToSync;
    public Slider thisValue;

    // Update is called once per frame
    void Update()
    {
        thisValue.value = valueToSync.value;
    }
    public IEnumerator SetMainToThis(Slider main, Slider thisText)
    {
        main.value = thisText.value;

        yield return null;
        StartCoroutine(SetMainToThis(main, thisText));

    }
}
