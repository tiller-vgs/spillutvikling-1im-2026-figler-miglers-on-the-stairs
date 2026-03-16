using UnityEngine;

public class Quit_game : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        //Get inputkey for player "escape"
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("This user has quit");
            Application.Quit();
        }
    }
}
