using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject player;
    public float speed;
    private Rigidbody pRb;
    public float force;

    public state playerState;
    public bool isLastStateDone = false;


    private bool isOnGround;

    public static Player Instance;


	void Start ()
    {
        pRb = player.GetComponent<Rigidbody>();
        isOnGround = true;
        Instance = this;
        playerState = state.run;
    }
	

	void Update ()
    {
        player.transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnGround)
        {
            Debug.Log("Space");
            jump();            
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
        switchState(state.jump);

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
        //Debug.Log("de");
        speed *= 0.5f;
    }

    public void dead()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "collider" )
        {
            isOnGround = true;
            switchState(state.run);
        }
    }

    public enum state
    {
        run,
        jump,
        trip
    }

   private void switchState(state s)
   {
        playerState = s;
        isLastStateDone = true;
   }


}
