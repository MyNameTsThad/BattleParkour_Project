using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PercentSetter : MonoBehaviour
{
    public TMP_Text text;
    public Slider slider;
    void Start()
    {
        text.text = slider.value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = slider.value.ToString();
    }
}
