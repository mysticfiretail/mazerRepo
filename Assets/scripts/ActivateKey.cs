using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActivateKey : MonoBehaviour
{
    public GameObject key;
    private Level level;
    // Start is called before the first frame update
    void Start()
    {
        key = GameObject.Find("MainKey");
    }

    // Update is called once per frame
    /*void Update()
    {
        if (level.levelcomplete == true)
        {
            key.SetActive(true);
        }
        else
        {
            key.SetActive(false);
        }
    }*/
}
