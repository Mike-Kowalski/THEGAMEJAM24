using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuControll : MonoBehaviour
{
    public string fileName;
    Save_Class enteries = new(0, 0, 0, 0);


    public Canvas leveloption;
        public void PlayGame()
        {
        enteries = file_handler.readFromJson<Save_Class>(fileName);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+enteries.current_level+1);
            

        }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }


    public void Level()
        {
          //  leveloption.alpha = 1;
            //leveloption.blocksRaycasts = true;

        }

        public void Back()
        {
            //leveloption.alpha = 0;
            //leveloption.blocksRaycasts = false;
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    
}
