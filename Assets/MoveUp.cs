using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveUp : MonoBehaviour
{
    public void SlideUp(bool UpOrDown)
    {
        if (UpOrDown)
        {
            LeanTween.scale(gameObject, new Vector3(1.4f, 1.2f, 0), .2f);
        }else
        {
            LeanTween.scale(gameObject, new Vector3(0, 0, 0), .3f);
            
        }
        
    }

}
