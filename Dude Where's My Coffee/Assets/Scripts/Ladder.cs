﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public float speed = 3; //Speed of Ladder movement

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKey(KeyCode.W)) //Moving up ladder
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        } else if (collision.tag == "Player" && Input.GetKey(KeyCode.S)) //Moving down ladder
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        } else
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1); //No movement, gravity
        }
    }
}
