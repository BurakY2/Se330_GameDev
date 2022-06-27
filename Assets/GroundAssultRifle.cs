using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAssultRifle : MonoBehaviour
{
   private void OnTriggerEnter(Collider other){
       
        if(other.gameObject.tag == "Player"){
            AmmoScript.secondGunFlag = true;
            Destroy(gameObject);
        }
    }
}
