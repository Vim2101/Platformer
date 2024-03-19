using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MyTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void MyTestsSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator MyTestsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }

    [UnityTest]
    public IEnumerator PlayerMovementTest()
    {
        GameObject player = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("Player"));
        Vector3 initialPosition = player.transform.position;

        player.GetComponent<Transform>().position = new Vector3(1, 1, 0);

        yield return null;

        Assert.AreNotEqual(initialPosition,player.transform.position);
        
    }
    
}
