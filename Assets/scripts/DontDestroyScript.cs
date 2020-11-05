﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyScript : MonoBehaviour
{
   void Awake ()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
