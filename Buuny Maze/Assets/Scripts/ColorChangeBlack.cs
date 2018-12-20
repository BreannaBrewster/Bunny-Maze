using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeBlack : MonoBehaviour {

    // Use this for initialization
    int counter = 0;
    int lightning = 0;
    SpriteRenderer renderReference;

    void Start()
    {
        renderReference = GetComponent<SpriteRenderer>();
        GetComponent<Renderer>().material.color = Color.clear;
    }
    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Renderer>().material.color != Color.white)
        {
            counter++;
        }
        if (counter >= 200)
        {
            GetComponent<Renderer>().material.color = Color.white;
            lightning++;
            
        }
        if(lightning >=10)
        {
            GetComponent<Renderer>().material.color = Color.clear;
            counter = 0;
            lightning = 0;
        }
    }

}
