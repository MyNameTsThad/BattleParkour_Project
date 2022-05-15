using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    public CoinCount count;
    
    // Start is called before the first frame update
    void Awake()
    {
        PlayerData data = SavingSystem.LoadSystem();
        data.coins = count.coins;
        
    }

   
}
