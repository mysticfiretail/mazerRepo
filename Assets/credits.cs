using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class credits : MonoBehaviour
{
    public void onClick(string creditscreen)
    {
        switch (creditscreen)
        {
            case "Credits":
                Debug.Log("Start!");
                SceneManager.LoadScene("End Screen");
                break;
        }
    }
}
