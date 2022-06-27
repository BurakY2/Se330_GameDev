using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform goal;
    public Transform Impact;
    private Animator anim;
    private NavMeshAgent agent;
    public bool AtackingTrigger = false;
    public bool Attackingmeal = false;
    
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
       
        try
        {
            float a = agent.speed;
            anim.SetFloat("Running", a);

            if(GameObject.Find("MeatBall(Clone)"))
            {
                
                Impact = GameObject.FindGameObjectWithTag("Impact").transform;
                agent.destination = Impact.position;
            }
            if(!GameObject.Find("MeatBall(Clone)"))
            {
                goal = GameObject.FindGameObjectWithTag("Player").transform;
                agent.destination = goal.position;
            }
            
            
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                anim.SetFloat("Running", 0);
            }

            if (AtackingTrigger == true)
            {
                Debug.Log("Attacking");
                anim.SetTrigger("Attack");
            }
            
        }
        catch
        {
            if (!GameObject.Find("Player"))
            {
                agent.speed = 0;
                Debug.Log("öldün çık");
                agent.isStopped = true;

            }
                
            
        }

    }
    

}
