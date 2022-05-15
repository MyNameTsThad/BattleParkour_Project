using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsManager : MonoBehaviour
{
    public GameObject[] Lights;

    public void Showlights(float index, bool ShowOrHide)
    {
        if (index <= Lights.Length)
        {
            if (ShowOrHide)
            {
                if (index == 0)
                {
                    Lights[0].SetActive(true);


                }
                if (index == 1)
                {
                    Lights[1].SetActive(true);
                    

                }
                if (index == 2)
                {
                    Lights[2].SetActive(true);
                    

                }
            }
            if (!ShowOrHide)
            {
                if (index == 0)
                {
                    Lights[0].SetActive(false);


                }
                if (index == 1)
                {
                    Lights[1].SetActive(false);


                }
                if (index == 2)
                {
                    Lights[2].SetActive(false);


                }
            }
        }else
        {
            Debug.LogError("index error");
        }
            
            
    }
    

}
