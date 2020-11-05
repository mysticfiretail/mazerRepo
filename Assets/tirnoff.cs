using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tirnoff : MonoBehaviour
{
    public Image scroll;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        scroll.enabled = false;
    }

}