using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class JumpingTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void JumpingTestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator JumpingTestWithEnumeratorPasses()
    {
        GameObject player = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("Player"));
        Vector3 initialPosition = player.transform.position;
        yield return null;


        Input.GetKeyDown(KeyCode.Space);

        yield return new WaitForSeconds(1);

        
         Assert.AreNotEqual(initialPosition,player.transform.position);
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        
    }
}
