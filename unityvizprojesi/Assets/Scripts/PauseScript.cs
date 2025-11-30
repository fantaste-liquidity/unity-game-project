using UnityEngine;

public class PauseButton : MonoBehaviour
{
    private bool isPaused = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            TogglePause();
        }
    }

    public void OnPauseButtonPressed()
    {
        TogglePause();
    }

    private void TogglePause()
    {
        if (isPaused)
        {
            // oyunu devam ettir
            Time.timeScale = 1f;
            isPaused = false;
            Debug.Log("Oyun devam ediyor");
        }
        else
        {
            // oyunu durdur
            Time.timeScale = 0f;
            isPaused = true;
            Debug.Log("Oyun durdu");
        }
    }
}
