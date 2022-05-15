using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    public int seconds = 30;
    public bool CountDownMode = false;
    private void Start()
    {
        timer.text = "00:" + seconds;
    }
    private void Update()
    {
        if (CountDownMode == false && seconds > 0)
        {
            StartCoroutine(TimerCountDown());
        }
    }
    IEnumerator TimerCountDown()
    {
        CountDownMode = true;
        yield return new WaitForSeconds(1);

        seconds -= 1;

        timer.text = "00:" + seconds;
        StartCoroutine(TimerCountDown());
    }
        
}
