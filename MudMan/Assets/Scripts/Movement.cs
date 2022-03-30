using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//small change
public class Movement : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //this is the game object that this script is attached to

        if (Input.GetKeyDown("s"))
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown("w"))
        {
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKeyDown("d"))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("a"))
        {
            rb.velocity = Vector3.right * speed;
        }
        else if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector3.up * speed;
        }
    }
}
