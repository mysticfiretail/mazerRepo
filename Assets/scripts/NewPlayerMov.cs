﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerMov : MonoBehaviour
{
    public Animator animator;
    public vectorValue startingPosition;


    void Start()
    {
       

    }

    void setPlayerCor()
    {
        transform.position = startingPosition.initialValue;
    }

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        transform.position = transform.position + movement * Time.deltaTime *4f;
    }
}
