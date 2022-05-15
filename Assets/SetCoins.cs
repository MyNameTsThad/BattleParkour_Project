using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetCoins : MonoBehaviour
{
    public TMP_Text text;
    void Update()
    {
        SnapValues();
    }
    public void SnapValues()
    {
        CoinCount coinCount = GameObject.FindObjectOfType<CoinCount>();

        
    }
}
