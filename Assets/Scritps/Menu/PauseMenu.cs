using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    // This shows the game pause menu
    public GameObject pauseMenuUI;
  
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                // If the game is paused, then resume playing 
                Resume();
            }
            else
            {
                // Otherwise pause the game, when not playing
                Pause();
            }
        }
    }

    public void Resume()
    {
        // If the pause menu is pressed, then this will allow the player to resume playing
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        // This will allow the player to pause the game
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true; 
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        // This will load the scene when the game is playing
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game..");
        // This will quit the game 
        Application.Quit();
    }
}
