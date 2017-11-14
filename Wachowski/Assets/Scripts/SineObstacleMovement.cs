using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineObstacleMovement : MonoBehaviour {

    public GameObject[] obstacleList = new GameObject[5];
    public Vector3[] obstaclePosition = new Vector3[5];
    
    // Use this for initialization
	void Start () {
		for(int i = 0; i < 5; i++)
        {
            obstaclePosition[i] = obstacleList[i].transform.position;
        }
	}
	
	// Update is called once per frame
	void Update () {
		

        for(int i = 0; i<5;i++)
        {
            obstacleList[i].transform.position = obstaclePosition[i] + new Vector3(Mathf.Sin(Time.time*2), 0f, 0f);
        }
	}
}
