using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthSetter : MonoBehaviour
{
    public TMP_Text text;
    public Slider healthBar;
    void Start()
    {
        text.SetText("100");
    }
    void Update()
    {
        float value = healthBar.value;
        text.SetText(value.ToString());
    }
}
