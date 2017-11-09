using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject player;
    public float speed;
    private Rigidbody pRb;
    public float force;

	// Use this for initialization
	void Start ()
    {
        pRb = player.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        player.transform.Translate(Vector3.right * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            pRb.AddForce(transform.up * force);
        }
    }
}
