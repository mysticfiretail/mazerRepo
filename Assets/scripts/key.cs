﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{

    [SerializeField] private KeyType keyType;

    public enum KeyType
    {

        red,
        green,
        blue,
        spawn,
        bxRoom,
        rRoom

    }

    public KeyType GetKeyType()
    {
        return keyType;
    }
}
