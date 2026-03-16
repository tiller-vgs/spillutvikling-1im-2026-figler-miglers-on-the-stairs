using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float remainingTime = 90f;
    [SerializeField] private GameObject gameOverPanel;

    private bool isGameOver = false;

    void Awake()
    {
        if (timerText == null)
        {
            timerText = FindAnyObjectByType<TextMeshProUGUI>();
            if (timerText == null)
            {
                Debug.Log("Timer");
            }
        }

    }

    void Update()
    {
        if (isGameOver) return;

        if (remainingTime > 0f)
        {
            remainingTime -= Time.deltaTime;

            if (remainingTime <= 0f)
            {
                remainingTime = 0f;
                timerText.color = Color.red;
                TriggerGameOver();
            }
        }

        UpdateTimerUI();
    }

    void UpdateTimerUI()
    {
        if (timerText == null) return;

        int minutes = Mathf.FloorToInt(remainingTime / 60f);
        int seconds = Mathf.FloorToInt(remainingTime % 60f);

        timerText.text = $"{minutes:00}:{seconds:00}";
    }

    void TriggerGameOver()
    {
        isGameOver = true;
        PlayerMovement player = FindObjectOfType<PlayerMovement>();
        if (player != null)
        {
            player.enabled = false;
        }

        Debug.Log("Game Over!");

    
        SceneManager.LoadScene("DeathScreen");
    



}

}


  







