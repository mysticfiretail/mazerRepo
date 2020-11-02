﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public bool levelcomplete;
    

    public void IsLevelComplete()
    {
        int box=0, boxtotal = 9;
        Target[] targets = FindObjectsOfType<Target>();
        foreach (var tar in targets)
        {
            if (!tar.m_BoxOnCross)
            {
                levelcomplete=  false;
            }
            else { 
                box++;
                if(box == boxtotal)
                {
                    levelcomplete = true;
                }
            }
  
        }
        
    }// Start is called before the first frame update
    private void Update()
    {
        IsLevelComplete(); 
    }
}
