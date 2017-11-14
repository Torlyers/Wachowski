using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject objectToFollow;
    public float speed;

    void Start()
    {
        speed = 5.0f;
    }

    void Update()
    {
        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (objectToFollow.transform.eulerAngles.y > -1f && objectToFollow.transform.eulerAngles.y < 1f)
        {
            speed = Mathf.Abs(speed);
        }
        else
        {
            speed = -Mathf.Abs(speed);
        }

        if(Mathf.Abs(gameObject.transform.position.x - objectToFollow.transform.position.x) > 10f)
        {
            Player.Instance.dead();
        }

       
        //float interpolation = speed * Time.deltaTime;

        //Vector3 position = this.transform.position;
        //position.y = Mathf.Lerp(this.transform.position.y, objectToFollow.transform.position.y, interpolation);
        //position.x = objectToFollow.transform.position.x + offset;
        //position.x += 0.2f;
       // this.transform.position = position;
    }
}