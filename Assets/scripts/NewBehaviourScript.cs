﻿using System.Collections;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public vectorValue startingPosition;
    public float speed;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        transform.position = startingPosition.initialValue;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2d.AddForce(movement * speed);
    }

}
