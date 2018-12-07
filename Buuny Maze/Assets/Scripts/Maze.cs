using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour {
    public GameObject[] wall;

    GameObject horizontalWall;
    GameObject verticalWall;
    public Transform spawnLocation;
    // Use this for initialization
    void Start () {
        
    }
    
	// Update is called once per frame
	void Update () {
        wall = new GameObject[2];
        wall[0] = horizontalWall;
        wall[1] = verticalWall;
        GameObject mazeWall = wall[0];
        for (int x = 0; x <= 20; x += 5)
        {
            for (int y = 0; y <= 20; y += 5)
            {

                if (Random.Range(0, 2) == 0)
                {
                    mazeWall = wall[0];
                }
                if (Random.Range(0, 2) == 1)
                {
                    mazeWall = wall[1];
                }

                Instantiate(wall[UnityEngine.Random.Range(0, 2)], spawnLocation.position, spawnLocation.rotation);
            }
        }
    }
}
