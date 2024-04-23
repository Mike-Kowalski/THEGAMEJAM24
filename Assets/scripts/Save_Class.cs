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
    public Save_Class(int found,int score, int CLV,int LVC)
    {
        collectables_found=found;
        this.score = score;
        current_level = CLV;
        level_cleared = LVC;
    }
}
