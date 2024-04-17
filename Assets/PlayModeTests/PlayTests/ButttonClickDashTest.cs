using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButttonClickDashTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void ButttonClickDashTestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator ButttonClickDashTestWithEnumeratorPasses()
    {
        SceneManager.LoadScene("Lv1");
        yield return new WaitForSeconds(1);

        GameObject player = GameObject.FindWithTag("Player");
        Assert.IsNotNull(player, "Player not found");

        Player playerScript = player.GetComponent<Player>();
        Assert.IsNotNull(playerScript, "Player component attached to the Player object not found");

        Vector3 initialPosition = player.transform.position;

        GameObject dashButton = GameObject.FindWithTag("DashButton");
        dashButton.GetComponent<Button>().onClick.Invoke();
        yield return new WaitForSeconds(2);
        Assert.AreNotEqual(initialPosition, player.transform.position);
        yield return null;
    }
}
