using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayScript : MonoBehaviour
{
    public void Replay()
    {
        int lastSceneIndex = PlayerPrefs.GetInt("lastScene", 0);
        SceneManager.LoadScene(lastSceneIndex);
    }

    
}
