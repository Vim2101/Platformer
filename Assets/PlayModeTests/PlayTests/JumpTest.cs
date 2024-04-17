using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JumpTest : MonoBehaviour
{
    [UnityTest]
    public IEnumerator PlayerJumpedTest()
    {
        SceneManager.LoadScene("Lv1");
        yield return new WaitForSeconds(2);
        // Load the player object from the scene
        GameObject playerObject = GameObject.FindWithTag("Player");
        Assert.IsNotNull(playerObject, "Player object not found in the scene");

        // Get the player's Rigidbody2D component
        Rigidbody2D rb = playerObject.GetComponent<Rigidbody2D>();
        Assert.IsNotNull(rb, "Rigidbody2D component not found on the player");

        // Save the initial position of the player
        Vector2 initialPosition = rb.position;

        // Simulate a jump by setting the player's velocity
        rb.velocity = new Vector2(rb.velocity.x, 10f); // Adjust the Y velocity to simulate the jump

        // Wait for a short duration to allow the jump to occur
        yield return new WaitForSeconds(0.1f); // Adjust the duration as needed

        // Assert that the player's position has changed (indicating a jump)
        Assert.AreNotEqual(initialPosition, rb.position, "Player did not jump as expected");
    }

   
    
}
