using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public GameObject player;
    public float speed;
    private Rigidbody pRb;
    public float force;

    public state playerState;
    public bool isLastStateDone = false;


    public bool isOnGround;

    public static Player Instance;

    private void Awake()
    {
        Instance = this;
    }


    void Start ()
    {
        pRb = player.GetComponent<Rigidbody>();
        isOnGround = true;        
        playerState = state.run;
    }
	

	void Update ()
    {
        player.transform.Translate(Vector3.right * speed * Time.deltaTime);       
    }

    public void jump()
    {
        if (isOnGround)
        {
            pRb.AddForce(transform.up * force);
            isOnGround = false;
            switchState(state.jump);
        }
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
        SceneManager.LoadScene("EndGame");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "collider" && !isOnGround)
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

   public void switchState(state s)
   {
        playerState = s;
        isLastStateDone = true;
   }


}
