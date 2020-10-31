using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public bool m_BoxOnCross;
  void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag== "Box")
        {
            //Debug.Log("OnCross");
            m_BoxOnCross = true;
        }
        else
        {
            m_BoxOnCross = false;
        }
    }
}
