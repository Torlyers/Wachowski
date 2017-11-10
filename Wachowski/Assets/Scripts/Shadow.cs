using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour {

    public GameObject shadow;
    public float speed;
    private Rigidbody pRb;
    public float force;

    // Use this for initialization
    void Start()
    {
        pRb = shadow.GetComponent<Rigidbody>();
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
}
