using UnityEngine;
using UnityEngine.SceneManagement;

public class ToggleWinScreen : MonoBehaviour
{
    public GameObject winScreenUI;
    public PlayerMovement playermovement; // 

    void OnTriggerEnter2D(Collider2D other) // Collider2D to trigger named "Other"
    {

        if (other.CompareTag("Player")) // Uses player tag
        {
            Debug.Log("Player touched the win block!");
            winScreenUI.SetActive(true); // Show Win Screen
            playermovement.enabled = false; // Disable Player Movement
            other.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero; // stop current movement
            other.GetComponent<Rigidbody2D>().simulated = false; // stops physics simulation
        }
    }

}
