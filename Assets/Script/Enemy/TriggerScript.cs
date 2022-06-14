using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject zombie;
    public EnemyController enemyController;
    // Start is called before the first frame update
    void Start()
    {
        enemyController = zombie.GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemyController.AtackingTrigger = true;
            Debug.Log("Attacking");
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemyController.AtackingTrigger = false;
            Debug.Log("Attacking");

        }
    }
}
