using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClickTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void ButtonClickTestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator ButtonClickTestWithEnumeratorPasses()
    {
        SceneManager.LoadScene("MainMenu");
        yield return new WaitForSeconds(1);

        GameObject button = GameObject.Find("PlayButton");

        Assert.IsNotNull(button, "Play button not found on the main menu");

       
        button.GetComponent<Button>().onClick.Invoke();
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;

        string currentSceneName = SceneManager.GetActiveScene().name;

        Assert.AreEqual("Lv1", currentSceneName, "Pressing play button did not direct to Lv1 scene");
    }
}
