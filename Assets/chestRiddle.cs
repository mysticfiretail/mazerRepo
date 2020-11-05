using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chestRiddle : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject chest;
    public GameObject Player;
    public Image scroll;
    public InputField inputField;
    public string Answer;
    public GameObject Key;

    void start()
    {
        //Key.SetActive(false);
     //   inputField.enabled = false;
scroll.enabled= false;
    }
   public void OnTriggerEnter2D (Collider2D collider)
    {
       
        //     inputField.enabled= true;
        scroll.enabled = true;
        Key.SetActive(true);

    }
     private void OnTriggerExit2D (Collider2D collider)
    {
        Debug.Log("riddle");
        scroll.enabled = false;
    }

  /*  void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            checkAnswer();
        }
    }

    public void checkAnswer ()
    {
        
    //    if (Answer == "flowers")
        {
            
            scroll.enabled= false;
            Key.SetActive(true);
        }
        else
        {
            inputField.text = "";
        }

    }
  */
}
