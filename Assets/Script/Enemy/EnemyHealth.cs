using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public float zombiehealth = 100f;
    private Animator anim;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(zombiehealth == 0 || zombiehealth < 0)
        {
            gameObject.tag = "Untagged";
            anim.SetBool("EnemyDead", true);
            agent.isStopped = true;
            Destroy(gameObject.GetComponent<Collider>());
            StartCoroutine(Dead());
        }
    }

    private IEnumerator Dead()
    {
        yield return new WaitForSeconds(8f);
        Destroy(gameObject);
    }

    public void hitByPlayer(float damage)
    {
        zombiehealth = zombiehealth - damage;
    }
}
