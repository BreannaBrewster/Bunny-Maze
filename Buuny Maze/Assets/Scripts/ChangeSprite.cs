using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class ChangeSprite : MonoBehaviour {

    public Sprite Down_Idle, Down_Idle2, Down_Move1, Down_Move2, Down_Move3,
        Left_idle, Left_Move1, Left_Move2, Left_Move3, Left_Move4,
        Right_Idle, Right_Move1, Right_Move2, Right_Move3, Right_Move4, 
        Up_Idle, Up_Idle2, Up_Move1, Up_Move2;
	// Use this for initialization
	void Start () {
		
	}
    static float time = 1;

    // Update is called once per frame
    void Update () {
        System.Timers.Timer timer = new System.Timers.Timer();
        timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        timer.Interval = 3000;
        timer.Enabled = true;                       
        if (Input.GetKey(KeyCode.W))
        {
            while (Input.GetKeyDown(KeyCode.W) == true)
            {
                time = 3;
                if (time == 3)
                {
                    this.GetComponent<SpriteRenderer>().sprite = Up_Idle;
                    time = time - 1;
                }
                if (time == 2)
                {
                    this.GetComponent<SpriteRenderer>().sprite = Up_Idle2;
                    time = time - 1;
                }
                if (time == 1)
                {
                    this.GetComponent<SpriteRenderer>().sprite = Up_Move1;
                    time = time - 1;
                }
                if (time == 0)
                {
                    this.GetComponent<SpriteRenderer>().sprite = Up_Move2;
                    time = time - 1;
                }
                if (time <= 0)
                {
                    time = 3;
                }
            }
            while (Input.GetKeyDown(KeyCode.W) == false)
            {
                time = 1;
                if (time == 1)
                {
                    this.GetComponent<SpriteRenderer>().sprite = Up_Idle;
                    time = time - 1;
                }
                if (time == 0)
                {
                    this.GetComponent<SpriteRenderer>().sprite = Up_Idle2;
                    time = time - 1;
                }
                if (time <= 0)
                {
                    time = 1;
                }
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<SpriteRenderer>().sprite = Down_Idle;
        }
    }
    static void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        time = time - 1;
    }
}
