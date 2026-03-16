using UnityEngine.SceneManagement;
using UnityEngine;

public class StartMenyKontroller : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("level_1");
    
    
    }
    
    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif 
        Application.Quit();
    }

}
