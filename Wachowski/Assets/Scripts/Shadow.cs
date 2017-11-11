using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour {

    public GameObject shadow;
    public float speed;
    private Rigidbody pRb;
    public float force;
    public float gravity;

    public static Shadow Instance;

    // Use this for initialization
    void Start()
    {
        pRb = shadow.GetComponent<Rigidbody>();
        Instance = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        shadow.transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("A");
            pRb.AddForce(transform.forward * force);
        }
    }

    void FixedUpdate()
    {
        pRb.AddForce(-transform.forward * 9.81f);

        //var grav = new Vector3(0, 0, 9.81f);
        //var pos = shadow.transform.position;
        //pos += grav * Time.fixedDeltaTime;
        //shadow.transform.position = pos;
    }
    void speedDown()
    {
        Debug.Log("Shadow slow down");
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
    //private void OnCollisionEnter(Collision collision)
    //{
    //   // Debug.Log("Shadow collision");
    //    if (collision.gameObject.tag == "obstacle2")
    //    {
    //        Debug.Log("Shadow slow down");
    //        speedDown();
    //    }
    //}
}
