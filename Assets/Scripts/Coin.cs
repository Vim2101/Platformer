using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject gameManager;
   CoinCollect coincollect;
    // Start is called before the first frame update
    void Start()
    {
        coincollect = gameManager.GetComponent<CoinCollect>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            coincollect.CoinCollected();
        }

        Destroy(this.gameObject);
    }
}
