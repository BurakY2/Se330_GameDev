using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float zombiehealth = 100f;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(zombiehealth == 0 || zombiehealth < 0)
        {
            anim.SetBool("EnemyDead", true);
        }
    }
}
