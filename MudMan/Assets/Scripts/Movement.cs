using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//small change
public class Movement : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody rb;
    [SerializeField] private float movespeed;
    [SerializeField] public float walkspeed;
    [SerializeField] public float runspeed;

    private Vector3 movedirection;
    private Vector3 velocity;

    [SerializeField] private bool isGrounded;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float Gravity;

    [SerializeField] private float jump_height;

    private CharacterController controller;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
         rb = this.gameObject.GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        //this is the game object that this script is attached to
        /*
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
        */
        Move();
    }
    private void Move()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float moveZ = Input.GetAxis("Vertical");

        movedirection = new Vector3(0, 0, moveZ);
        movedirection *= walkspeed;

        if(isGrounded)
        {
            if (movedirection != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
            {
                Walk();
                print("..........");
            }
            else if (movedirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
            {
                Run();
            }
            else if (movedirection == Vector3.zero)
            {
                Idle();
            }
            movedirection *= movespeed;

            if(Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
                print(".................");
            }
        }
        
        
        controller.Move(movedirection * Time.deltaTime);
        velocity.y += Gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    }
    private void Idle()
    {

    }
    private void Walk()
    {
        movespeed = walkspeed;
        print(".................");
    }
    private void Run()
    {
        movespeed = runspeed;
    }
    private void Jump()
    {
        velocity.y = Mathf.Sqrt(jump_height * -2 * Gravity);
    }

}
