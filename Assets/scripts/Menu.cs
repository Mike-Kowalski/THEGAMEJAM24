using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   // public AudioSource BackgroundMusic;
   // public AudioSource ClickSound;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //ClickSound.Play();
       // BackgroundMusic.Play();

    }

    public void GoToLevel()
    {
        SceneManager.LoadScene("Level");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
