using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonJumpTest
{
    [UnityTest]
    public IEnumerator ButtonJumpTestPlayMode()
    {
        SceneManager.LoadScene("Lv1");
        yield return new WaitForSeconds(2);
        // Load the player object from the scene
        GameObject playerObject = GameObject.FindWithTag("Player");
        Assert.IsNotNull(playerObject, "Player object not found in the scene");
        
        GameObject button = GameObject.FindWithTag("Button");
        Assert.IsNotNull(button, "Jump Button object not found");
        
        //Get the player's Rigidbody2D component
        Rigidbody2D rb = playerObject.GetComponent<Rigidbody2D>();
        Assert.IsNotNull(rb, "Rigidbody2D component not found on the player");

        // Save the initial position of the player
        Vector2 initialPosition = rb.position;
        var initialVelocity = rb.velocity;

        // Simulate a jump by pressing the jump button
       button.GetComponent<Button>().onClick.Invoke();

        // Wait for a short duration to allow the jump to occur
        yield return new WaitForSeconds(0.1f); // Adjust the duration as needed

        // Assert that the player's position has changed (indicating a jump)
        Assert.AreNotEqual(initialPosition, rb.position, "Player did not jump as expected");
        Assert.AreNotEqual(initialVelocity, rb.velocity, "Player did not jump because velocity is the same");

        yield return new WaitForSeconds(2);
    }
}
