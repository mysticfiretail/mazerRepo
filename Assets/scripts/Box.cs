using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Box : MonoBehaviour
{
    SpriteRenderer boxitself;
    Sprite OffCross;
    public Sprite OnCross;

    void Start()
    {
        boxitself = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Target")
        {
            boxitself.sprite = OnCross;
        }
    }
}
