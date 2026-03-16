using UnityEngine;
using UnityEngine.SceneManagement;


public class WhenPlayerDies_Script : MonoBehaviour
{
    public void PlayerDies()
    {
        int level = PlayerPrefs.GetInt("LastLevel", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(level);  
    }
}
