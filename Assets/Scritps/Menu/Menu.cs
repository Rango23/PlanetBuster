using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class Menu : MonoBehaviour
    {
        public void PlayGame()
        {
        // This allows to change between scenes
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);    
        }

        public void ExitGame()
        {
            // This shows that the game has stopped playing
            Debug.Log("Exit!");
            Application.Quit();
        }
    }


