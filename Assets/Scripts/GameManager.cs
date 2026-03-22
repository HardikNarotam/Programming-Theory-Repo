using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; private set; }
    public int lives = 20;
    private bool isGameOver = false;
    public GameObject gameOverPanel;
    public GameObject winPanel;
    public EnemySpawner enemySpawner;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int amount)
    {
        if (isGameOver) return;

        lives -= amount;
        if (lives <= 0)
        {
            GameOver();
        }
    }

    public void CheckWinCondition()
    {
        if (enemySpawner.currentWaveIndex >= enemySpawner.waves.Count && GameObject.FindObjectsByType<Prim>(FindObjectsSortMode.None).Length <= 1)
        {
            isGameOver = true;
            winPanel.SetActive(true);
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
