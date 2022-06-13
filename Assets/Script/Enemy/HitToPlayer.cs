using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitToPlayer : MonoBehaviour
{
    [SerializeField]
    private PlayerHeal playerheal;
    private void Start()
    {
        playerheal = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHeal>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Enemy Atacking");
            playerheal.PlayerHealth -= 2f;
            
        }
    }
}
