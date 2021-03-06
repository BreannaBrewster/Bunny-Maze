﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunny : MonoBehaviour
{
    public Animator animator;
    Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        AudioManager.Instance.PlayOneShot(SoundEffect.Music);
    }
    [SerializeField]
    float speed = 4f;
    Vector3 velocity = new Vector3(0, 0, 0);
    float LeftMove = 0f;
    float rightMove = 0f;
    float downMove = 0f;
    float upMove = 0f;
    bool Down = false;
    bool Up = false;
    bool Left = false;
    bool Right = false;
    // Update is called once per frame
    void Update()
    {
        //LeftMove = Input.GetAxisRaw("Horizontal") * speed;
        //animator.SetFloat("Down", Mathf.Abs(downMove));
        if (Input.GetKey(KeyCode.W))
        {
            Up = true;
            animator.SetBool("Up", true);
            if (transform.position.y < 12)
            {
                transform.position += .5f * Vector3.up * Time.deltaTime * speed;
            }
        }
        else
        {
            animator.SetBool("Up", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Down", true);
            Down = true;
            if (transform.position.y > -12)
            {
                transform.position += .5f * Vector3.down * Time.deltaTime * speed;
            }
        }
        else
        {
            animator.SetBool("Down", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Right", true);
            Right = true;
            if (transform.position.x < 19.75f)
            {
                transform.position += .5f * Vector3.right * Time.deltaTime * speed;
            }
        }
        else
        {
            animator.SetBool("Right", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Left", true);
            Left = true;
            if (transform.position.x > -19.75f)
            {
                transform.position += .5f * Vector3.left * Time.deltaTime * speed;
            }
        }
        else
        {         
            animator.SetBool("Left", false);
        }
        
    }
}


