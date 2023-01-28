using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    public Rigidbody rb;
    public float forwardforce = KeepData1.PlayingSpeed;
    public float sidewaysForce = 120f;

    // Update is called once per frame
    void FixedUpdate() //FixedUpdate for physics
    {
        forwardforce = KeepData1.PlayingSpeed;
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
