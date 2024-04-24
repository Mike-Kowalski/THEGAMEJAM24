using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public string fileName;
    Save_Class enteries = new(0, 0, 0, 0);
    public Button[] buttons;
    public GameObject levelButtons;

    public SceneManager[] levels;
 

    public void Awake()
    {
        enteries = file_handler.readFromJson<Save_Class>(fileName);
        ButtonsToArray();
        int unlockedLevel = enteries.level_cleared; 
            //PlayerPrefs.GetInt("UnlockedLevel", 1);
        for(int i =- 0; i <unlockedLevel; i++)
        {
            buttons[i].interactable = false;

        }
        for(int i=0; i < unlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void OpenLevel(int levelId)
    {
        string levelName = "Level" + levelId;
        SceneManager.LoadScene(levelName);
    }

    public void ButtonsToArray()
    {
        int childCount = levelButtons.transform.childCount;
        buttons = new Button[childCount];
        for (int i = 0; i < childCount; i++)
        {
            buttons[i] = levelButtons.transform.GetChild(i).gameObject.GetComponent<Button>();
        }       

    }
   

}
