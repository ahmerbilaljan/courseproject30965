using UnityEngine;
using UnityEngine.UI; // For displaying the score on UI

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton pattern for global access
    public GameObject gameOverText;

    public int score = 0; // The player's score
    public Text scoreText; // UI Text element to display the score

    void Awake()
    {
        // Ensure only one instance of GameManager exists
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        score += points; // Increment the score
        UpdateScoreText(); // Update the UI
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
 

    public void GameOver()
    {
        if (gameOverText != null)
        {
            gameOverText.SetActive(true); // Show the "Game Over" text
        }
        Time.timeScale = 0; // Pause the game (optional)
    }
}
