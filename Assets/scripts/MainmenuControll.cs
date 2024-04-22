using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuControll : MonoBehaviour
{
    

        public CanvasGroup leveloption;
        public void PlayGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            

        }

        public void Level()
        {
            leveloption.alpha = 1;
            leveloption.blocksRaycasts = true;

        }

        public void Back()
        {
            leveloption.alpha = 0;
            leveloption.blocksRaycasts = false;
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    
}
