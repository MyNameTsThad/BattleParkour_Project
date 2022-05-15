using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Points : MonoBehaviour
{
    public TMP_Text ScoreText;
    public TMP_Text HighScoreText;

    public float points = 0;

    private void Start()
    {
        points = 0;
        ScoreText.text = points.ToString();
        HighScoreText.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }
    public void AddPoints(float pointsToAdd)
    {
        points += pointsToAdd;
        ScoreText.text = points.ToString();

        if (points > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", points);
            HighScoreText.text = points.ToString();
        }
        
    }
}
