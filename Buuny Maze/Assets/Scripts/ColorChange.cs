using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {
    // Use this for initialization

    private int counter = 0;
    public List<Color> colors; //list of colors, can be changed in inspector
    SpriteRenderer renderReference;
    void OnCollisionEnter2D(Collision2D coll)
    {
        //if (coll.other.tag == "Wall") { //uncomment to check tag of colliding object
        //if (counter < colors.Count - 1)
        //{
            //counter++;
        //}
        //else
        //{
            //counter = 0;
        //}
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
    //} //uncomment to check tag of colliding object


    void Start()
    {
        renderReference = GetComponent<SpriteRenderer>();
        GetComponent<Renderer>().material.color = Color.white;
    }
    // Update is called once per frame
    void Update () {
    }
}
