using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private void awake()
    {
        levelcomplete = false;
    }
    public bool levelcomplete;

    public void IsLevelComplete()
    {
        Target[] targets = FindObjectsOfType<Target>();
        foreach (var target in targets)
        {
            if (!target.m_BoxOnCross)
            {
                levelcomplete=  false;
            }
            else
            {
                levelcomplete = true;
            }

        }
        
    }// Start is called before the first frame update

}
