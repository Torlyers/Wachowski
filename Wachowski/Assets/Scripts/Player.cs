using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject player;
    public float speed;
    private Rigidbody pRb;
    public float force;

    private int offset = 0;

    public state playerState;


    private bool isOnGround;

    public static Player Instance;

	// Use this for initialization
	void Start ()
    {
        pRb = player.GetComponent<Rigidbody>();
        isOnGround = true;
        Instance = this;
        playerState = state.run;
    }
	
	// Update is called once per frame
	void Update ()
    {
        player.transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnGround)
        {
            Debug.Log("Space");
            jump();            
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

    public void jump()
    {
        pRb.AddForce(transform.up * force);
        isOnGround = false;
        playerState = state.jump;
    }

    public void changeDir()
    {
        //speed *= -1;
        transform.eulerAngles += new Vector3(0, 180, 0);
    }

    public void accelerate()
    {
        speed *= 2f;
    }

    public void decelerate()
    {
        Debug.Log("de");
        speed *= 0.5f;
    }

    public void dead()
    {

    }

    //void speedDown()
    //{
    //    Debug.Log("Player slow down");
    //}
    //private void OnTriggerEnter(Collider collision)
    //{
    //    
    //    if (collision.gameObject.tag == "obstacle1")
    //    {
            
    //        speedDown();
    //    }
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "collider" )
        {
            isOnGround = true;
            playerState = state.run;
        }
    }

    public enum state
    {
        run,
        jump,
        trip
    }



}
