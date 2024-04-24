using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetSaveData : MonoBehaviour
{
    Button ResetButton;
    Save_Class enteries = new Save_Class(0, 0, 0, 0);
    [SerializeField]
    public string fileName;
    public void ResetData()
    {
        enteries.collectables_found = 0;
        enteries.current_level = 0;
        enteries.level_cleared = 0;
        enteries.score = 0;

        
        file_handler.saveToJson<Save_Class>(enteries,fileName);
        Debug.Log("You have clicked the reset button!");
    }
   
}
