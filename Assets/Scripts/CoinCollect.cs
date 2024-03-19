using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public int _coin = 0;
    
     /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
     void Awake()
    {
        //GameObject coin = GameObject.Find("Coin");
    }
    
    public void CoinCollected()
    {
        _coin++;
    }

    public int GetCurrentCoinAmount()
    {
        return _coin;
    }
/// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
     
}
