using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        // Load the main game scene UnityEngine.SceneManagement.SceneManager.LoadScene("MainGameScene");
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
