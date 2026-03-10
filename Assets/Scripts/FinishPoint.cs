using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");
            SceneController.instance.NextLevel();
        }
    }
}
