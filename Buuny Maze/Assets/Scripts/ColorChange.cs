using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    // Use this for initialization

    int counter = 0;
    SpriteRenderer renderReference;
    void OnCollisionEnter2D(Collision2D coll)
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    void Start()
    {
        renderReference = GetComponent<SpriteRenderer>();
        GetComponent<Renderer>().material.color = Color.white;
    }
    // Update is called once per frame
    void Update () {
        if(GetComponent<Renderer>().material.color != Color.white)
        {
            counter++;
        }
        if(counter >= 15)
        {
            GetComponent<Renderer>().material.color = Color.white;
            counter = 0;
        }
    }
}
