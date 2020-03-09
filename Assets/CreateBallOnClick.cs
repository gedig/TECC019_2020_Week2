using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBallOnClick : MonoBehaviour
{
    public GameObject ball = null;
    public float ballSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBall = Instantiate(ball,
            transform.position + transform.forward,
            transform.rotation);


            newBall.GetComponent<Rigidbody>().AddForce(transform.forward * ballSpeed);
        }
    }
}
