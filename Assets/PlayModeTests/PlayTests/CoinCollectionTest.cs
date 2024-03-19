using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CoinCollectionTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void CoinCollectionTestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CoinCollectionTestWithEnumeratorPasses()
    {
        yield return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Lv1");

        GameObject player = GameObject.FindWithTag("Player");
        Assert.IsNotNull(player, "Player not found");
        GameObject gameManager = GameObject.FindWithTag("GameManager");
        Assert.IsNotNull(gameManager, "Game Manager not found");

        CoinCollect coinCollect = GameObject.FindObjectOfType<CoinCollect>();

        for(int i = 0; i < 3; i++)
        {
            GameObject coin = GameObject.FindWithTag("Coin");

            Assert.IsNotNull(coin, "Coin not found");

            player.transform.position = coin.transform.position;
            
            yield return null;
        }

        int currentCoinAmount = coinCollect.GetCurrentCoinAmount();

        Assert.AreEqual(3, currentCoinAmount, "Current coin amount is not correct");
    
    }
}

