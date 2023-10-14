using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Score score;
    public float gameDuration = 100.0f;
    public string mainMenuSceneName = "MainMenu"; 

    private float timer;

    private void Start()
    {
        timer = gameDuration;
    }

    private void Update()
    {
        // Decrease the timer every frame.
        timer -= Time.deltaTime;

        // Check if the score reaches 100.
        if (score.GetScore() >= 100)
        {
            LoadMainMenu();
        }

        // Check if the timer reaches 0.
        if (timer <= 0)
        {
            LoadMainMenu();
        }
    }

    private void LoadMainMenu()
    {
        // Load the main menu scene.
        SceneManager.LoadScene(mainMenuSceneName);
    }
}
