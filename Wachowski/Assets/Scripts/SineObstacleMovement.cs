using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineObstacleMovement : MonoBehaviour {

    public GameObject[] obstacleList1 = new GameObject[5];
    public GameObject[] obstacleList2 = new GameObject[2];

    private Vector3[] obstaclePosition1 = new Vector3[5];
    private Vector3[] obstaclePosition2 = new Vector3[2];

    // Use this for initialization
    void Start () {
		for(int i = 0; i < 5; i++)
        {
            obstaclePosition1[i] = obstacleList1[i].transform.position;
        }
        for (int i = 0; i < 2; i++)
        {
            obstaclePosition2[i] = obstacleList2[i].transform.position;
        }
    }
	
	// Update is called once per frame
	void Update () {
		

        for(int i = 0; i<5;i++)
        {
            obstacleList1[i].transform.position = obstaclePosition1[i] + new Vector3(Mathf.Sin(Time.time * 5), 0f, 0f );
        }
        for(int i = 0; i < 2; i++)
        {
            obstacleList2[i].transform.position = obstaclePosition2[i] + new Vector3(0f, 0f, Mathf.Sin(Time.time * 2) * 2);
        }
    }
}
