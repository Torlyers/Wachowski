using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject player;
    public float speed;
    private Rigidbody pRb;
    public float force;

    private bool isOnGround;

	// Use this for initialization
	void Start ()
    {
        pRb = player.GetComponent<Rigidbody>();
        isOnGround = true;
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

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            pRb.AddForce(transform.up * force);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            changeDir();
        }
    }

    void changeDir()
    {
        speed *= -1;
        transform.position *= -1;
    }

    void speedDown()
    {

    }


}
