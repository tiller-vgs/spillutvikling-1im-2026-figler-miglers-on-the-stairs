using Assets.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieWhenDead : MonoBehaviour
{
    private HealthService health;
    public string sceneToLoad = "DeathScreen";

    void Start()
    {
        health = GetComponent<HealthService>();
    }

    void Update()
    {
        if (health != null && health.CurrentHealth <= 0)
        {
            if (CompareTag("Player"))
            {
                SceneManager.LoadScene(sceneToLoad);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
