using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class CoinCount : MonoBehaviour
{
    public float coins = 0;
    public TMP_Text count;
    

    private void Start()
    {
        coins = PlayerPrefs.GetFloat("CoinsCount", 0);
        count.text = coins.ToString();

        count.text = PlayerPrefs.GetFloat("CoinsCount", 0).ToString();

        
    }
    public void AddAndSetCoins(float coinsToAdd)
    {
        coins += coinsToAdd;
        
        count.text = coins.ToString();


        PlayerPrefs.SetFloat("CoinsCount", coins);
    }
 


    
    
}
