using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {    

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Player.Instance.decelerate();
        }
        else if(other.gameObject.tag == "Shadow")
        {
            Shadow.Instance.decelerate();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.Instance.accelerate();
        }
        else if(other.gameObject.tag == "Shadow")
        {
            Shadow.Instance.decelerate();
        }
    }
}
