using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DashingTest
{
    [UnityTest]
    public IEnumerator DashingTestWithEnumeratorPasses()
    {
        SceneManager.LoadScene("Lv1");
        yield return new WaitForSeconds(1);
        GameObject player = GameObject.FindWithTag("Player");
        Assert.IsNotNull(player, "Player not found");
        Player playerScript = player.GetComponent<Player>();
        Assert.IsNotNull(playerScript, "Player component attached to the Player object not found");
        Vector3 initialPosition = player.transform.position;
        //Simulate Dashing
        //Input.GetKeyDown(KeyCode.C);
        playerScript.ButtonDash();

        
        yield return new WaitForSeconds(0.1f);

        Assert.AreNotEqual(initialPosition, player.transform.position);
        
        Assert.IsTrue(playerScript.isDashing, "Player is not dashing");

       

        
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
