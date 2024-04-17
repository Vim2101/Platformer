using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class JumpingTest
{
    
    [UnityTest]
    public IEnumerator JumpingTestWithEnumeratorPasses()
    {
        yield return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Lv1");
        GameObject player = GameObject.FindWithTag("Player");
        Assert.IsNotNull(player, "Player Game Object not found.");
        Vector3 initialPosition = player.transform.position;
        Player playerScript = player.GetComponent<Player>();

        Input.GetKeyDown(KeyCode.Space);
       

        yield return new WaitForSeconds(1);

        Assert.AreNotEqual(initialPosition,player.transform.position);
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        
    }
}
