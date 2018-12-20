using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightning : MonoBehaviour {

    int counter = 0;
    int flash = 0;
    SpriteRenderer renderReference;

    void Start()
    {
        renderReference = GetComponent<SpriteRenderer>();
        GetComponent<Renderer>().material.color = Color.clear;
    }
    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter >= 199)
        {
            GetComponent<Renderer>().material.color = Color.clear;
            flash++;

        }
        if (flash >= 10)
        {
            GetComponent<Renderer>().material.color = Color.clear;
            counter = 0;
            flash = 0;
        }
    }
}
