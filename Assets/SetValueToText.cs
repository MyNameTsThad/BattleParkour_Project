using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SetValueToText : MonoBehaviour
{
    public TMP_Text percent;
    public Slider volSlider;
    private void Start()
    {
        percent.text = (volSlider.normalizedValue * 100).ToString() + "%";
    }
    private void Update()
    {
        percent.text = (volSlider.normalizedValue * 100).ToString() + "%";
    }
}
