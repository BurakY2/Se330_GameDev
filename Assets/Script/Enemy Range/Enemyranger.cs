
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemyranger : MonoBehaviour
{
    public Transform goal;
    private Animator anim;
    private NavMeshAgent agent;
    public bool AtackingTrigger = false;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        goal = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        try
        {
            float a = agent.speed;
            anim.SetFloat("Running", a);
            agent.destination = goal.position;
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                anim.SetFloat("Running", 0);
            }

            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                Debug.Log("Attacking");
                anim.SetTrigger("Attack");
            }

        }
        catch
        {
            agent.speed = 0;
            Debug.Log("öldün çık");
            agent.isStopped = true;

        }






    }



}  
    