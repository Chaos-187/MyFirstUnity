using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float sidewaysForce = 500f;

   

    // Update is called once per frame
    void Update()
    {
        // Send Character forward
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime,ForceMode.VelocityChange);

        //Character Left
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
       //Character Left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
    }
}
