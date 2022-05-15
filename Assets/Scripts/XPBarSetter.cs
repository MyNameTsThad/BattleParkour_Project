using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class XPBarSetter {

    public event EventHandler OnExperienceChanged;
    public event EventHandler OnLevelChanged;

    private int Level;
    private int experienceLevel;
    private int experienceToNextLevel;
    
    public XPBarSetter()
    {
        Level = 0;
        experienceLevel = 0;
        experienceToNextLevel = 100;
        
    }
    public void AddExperience(int ammount)
    {
        experienceLevel += ammount;
        if (experienceLevel >= experienceToNextLevel)
        {
            Level++;
            experienceLevel -= experienceToNextLevel;
            if (OnLevelChanged != null) OnExperienceChanged(this, EventArgs.Empty);
        }
        if (OnExperienceChanged != null) OnExperienceChanged(this, EventArgs.Empty);
        
    }
    public int GetLevelNumber()
    {
        return Level;
    }
    public float GetExperience()
    {
        return (float)experienceLevel / experienceToNextLevel;
    }
}
