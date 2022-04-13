using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Loco : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
        
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = playerTransform.position;
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }
}
