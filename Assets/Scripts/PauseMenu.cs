using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;  // Reference to the Pause Panel
    private bool isPaused = false;

    void Update()
    {
        // Toggle pause when the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    // Called when the game is paused
    public void PauseGame()
    {
        pausePanel.SetActive(true);  // Show the pause menu
        Cursor.lockState = CursorLockMode.None;
        //Time.timeScale = 0f;         // Freeze game time
        isPaused = true;
    }

    // Called when the game is resumed
    public void ResumeGame()
    {
        pausePanel.SetActive(false);  // Hide the pause menu
        Cursor.lockState = CursorLockMode.Locked;
        //Time.timeScale = 1f;          // Resume game time
        isPaused = false;
    }

/*
    // Restart the current level
    public void RestartGame()
    {
        Time.timeScale = 1f;  // Ensure timeScale is normal before restarting
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  // Reload the current scene
    }
*/

    // Quit the game
    public void QuitGame()
    {
        //Time.timeScale = 1f;  // Ensure timeScale is normal before quitting
        Application.Quit();    // Quit the application
        // For testing in the editor:
    
        #if UNITY_EDITOR
            // Stop playing the game in the Unity Editor
            UnityEditor.EditorApplication.isPlaying = false;
        #endif

        /*
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        */
    } 



}
