using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayAwake : MonoBehaviour
{

    private static StayAwake wakey = null;

    void Awake()
    {
        if (wakey == null)
        {
            wakey = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
