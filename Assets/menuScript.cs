using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public void onClick(string menuBtns)
    {
        switch (menuBtns)
        {
            case "Start":
                Debug.Log("Start!");
                SceneManager.LoadScene("SpawnRoom");
            break;

            case "Options":
                SceneManager.LoadScene("Options");
                break;
        }

        
    }
}
