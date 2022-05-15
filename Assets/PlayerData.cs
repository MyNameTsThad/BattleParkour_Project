using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public float coins;
    
    
    public PlayerData(CoinCount coincount)
    {
        coins = coincount.coins;
        coincount.coins = coins;
    }
}
