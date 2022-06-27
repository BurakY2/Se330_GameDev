using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : MonoBehaviour
{
    public GameObject game ;
    public Transform a;
    public static Vector3 initialPoint;
    // Start is called before the first frame update
    void Update()
    {
        initialPoint = a.position;
        
            
            
    }

    void rangeAttack(){
        Instantiate(game , a.position , a. rotation);
    }
}
