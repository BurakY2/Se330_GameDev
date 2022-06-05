using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform goal;
    private Animator anim;
    private NavMeshAgent agent;
    
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
         
        float a = agent.speed;
        anim.SetFloat("Running", a);
        agent.destination = goal.position;

        
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            anim.SetFloat("Running", 0);
        }
        


    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Attacking");
            anim.SetTrigger("Attack");
        }
    }
}
