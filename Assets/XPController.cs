using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class XPController : MonoBehaviour
{
    public TMP_Text levelText;
    public Slider XPBar;
    private XPBarSetter barSetter;
    
    private void Awake()
    {
        SetLevelNumber(1);
    }
    public void SetXPBar(float XP)
    {
        XPBar.value = XP;
    }
    public void SetLevelNumber(int LVL)
    {
        levelText.text = LVL.ToString();
    }
    public void SetXPBarSetter(XPBarSetter xpBarSetter)
    {
        this.barSetter = xpBarSetter;
        SetLevelNumber(barSetter.GetLevelNumber());
        SetXPBar(barSetter.GetExperience());

        barSetter.OnExperienceChanged += BarSetter_OnExperienceChanged;
        barSetter.OnLevelChanged += BarSetter_OnLevelChanged;
    }

    private void BarSetter_OnLevelChanged(object sender, System.EventArgs e)
    {
        SetLevelNumber(barSetter.GetLevelNumber());
    }

    private void BarSetter_OnExperienceChanged(object sender, System.EventArgs e)
    {
        SetXPBar(barSetter.GetExperience());
    }
}
