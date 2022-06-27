using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    public GameObject projectile ;
    public Transform tip;
    public static Vector3 initialPoint;
    // Start is called before the first frame update
    void Update()
    {
       
            
    }

    void RangeAttack(){
        initialPoint = tip.position;
        Instantiate(projectile , tip.position , tip. rotation);
    }
}
