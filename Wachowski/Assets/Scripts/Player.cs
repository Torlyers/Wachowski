using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject player;
    public float speed;
    private Rigidbody pRb;
    public float force;

    private bool isOnGround;

    public static Player Instance;

	// Use this for initialization
	void Start ()
    {
        pRb = player.GetComponent<Rigidbody>();
        isOnGround = true;
        Instance = this;
    }
	
	// Update is called once per frame
	void Update ()
    {
        player.transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnGround)
        {
            Debug.Log("Space");
            pRb.AddForce(transform.up * force);
            isOnGround = false;
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

    public void changeDir()
    {
        //speed *= -1;
        transform.localEulerAngles += new Vector3(0, 180, 0);
    }

    public void accelerate()
    {
        speed *= 2f;
    }

    public void decelerate()
    {
        speed *= 0.5f;
    }
    void speedDown()
    {
        Debug.Log("Player slow down");
    }
    private void OnTriggerEnter(Collider collision)
    {
        ;
        if (collision.gameObject.tag == "obstacle1")
        {
            
            speedDown();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "collider" )
        {
            isOnGround = true;
        }
    }

}
