using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goBack : MonoBehaviour
{
   
    public void onClick(string goBackbtn)
    {
        switch (goBackbtn)
        {
            case "Back":
                Debug.Log("Start!");
                SceneManager.LoadScene(0);
                break;
        }


    }
}
