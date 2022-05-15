using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarController : MonoBehaviour
{
    public Slider HealthBar;
    public Gradient healthBarFill;
    public Image Fill;
    public void SetMaxHealth(float maxHealth)
    {
        HealthBar.maxValue = maxHealth;
        HealthBar.value = maxHealth;
        Fill.color = healthBarFill.Evaluate(1f);
    }

    public void SetHealth(float health)
    {
        HealthBar.value = health;
        Fill.color = healthBarFill.Evaluate(HealthBar.normalizedValue);
    }
}
