using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour {

    public GameObject shadow;
    public float speed;
    private Rigidbody pRb;
    public float force;
    public float gravity;
    private bool isOnGround;

    // Use this for initialization
    void Start()
    {
        pRb = shadow.GetComponent<Rigidbody>();
        isOnGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        shadow.transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.DownArrow) && isOnGround)
        {
            Debug.Log("DownArrow");
            pRb.AddForce(transform.up * force);
            isOnGround = false;
        }
        
    }

    void FixedUpdate()
    {
        //pRb.AddForce(-transform.forward * 9.81f * gravity);

        //var grav = new Vector3(0, 0, 9.81f);
        //var pos = shadow.transform.position;
        //pos += grav * Time.fixedDeltaTime;
        //shadow.transform.position = pos;
    }
    void speedDown()
    {
        Debug.Log("Shadow slow down");
    }
    private void OnTriggerEnter(Collider collision)
    {
       // Debug.Log("Shadow collision");
        if (collision.gameObject.tag == "obstacle2")
        {
            //Debug.Log("Shadow slow down");
            speedDown();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "collider")
        {
            isOnGround = true;
        }
    }
}
