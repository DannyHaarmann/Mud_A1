using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemey  : MonoBehaviour
{
    private int count;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        rb = this.gameObject.GetComponent<Rigidbody>();

        count = 0;

        rb.velocity = new Vector3(Random.Range(-6, 6), 0, Random.Range(-6, 6));
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            CORE.display();
            count++;
            if (count == 3)
            {
                this.gameObject.SendMessage("DoSomething");
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}