using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject gameOverUI; 

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

        Time.timeScale = 1f;

        if (gameOverUI != null)
        {
            gameOverUI.SetActive(false);
        }
    }

    public void GameOver()
    {
        Debug.Log("GameManager.GameOver çağrıldı");

        Time.timeScale = 0f;

        // game over panelini aç
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        Scene current = SceneManager.GetActiveScene();
        SceneManager.LoadScene(current.buildIndex);
    }



    public void QuitGame()
    {
        Time.timeScale = 1f;   
        SceneManager.LoadScene("Anamenu");
    }

    public void GoToMainMenu()
    {
        // oyun durdurulduysa zamanı normale çek
        Time.timeScale = 1f;

        // ana menü sahnesini yükle
        SceneManager.LoadScene("Anamenu"); 
    }

}
