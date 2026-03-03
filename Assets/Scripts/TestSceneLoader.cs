using UnityEngine;
using UnityEngine.SceneManagement;


public class TestSceneLoader : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("DeathScreen", LoadSceneMode.Additive);
        SceneManager.LoadScene("Level1", LoadSceneMode.Additive);
        SceneManager.LoadScene("Enemy_Spawn", LoadSceneMode.Additive);
        SceneManager.LoadScene("enemytest", LoadSceneMode.Additive);
        SceneManager.LoadScene("Heart_System", LoadSceneMode.Additive);
        SceneManager.LoadScene("Start_Scene", LoadSceneMode.Additive);
        SceneManager.LoadScene("TEST_SCENEEEE", LoadSceneMode.Additive);
        SceneManager.LoadScene("Timer_Scene", LoadSceneMode.Additive);

    }
}
