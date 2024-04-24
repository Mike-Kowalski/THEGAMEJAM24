using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Save_Class
{
        public int collectables_found;
        public int score;
        public int current_level;
        public int level_cleared;
        public bool Collected1;
    public bool Collected2;
    public bool Collected3;
    public bool Collected4;
    public bool Collected5;
    public bool Collected6;
    public Save_Class(int found,int score, int CLV,int LVC)
    {
        
        collectables_found =found;
        this.score = score;
        current_level = CLV;
        level_cleared = LVC;
    }
    
}
