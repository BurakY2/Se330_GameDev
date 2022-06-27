using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impact : MonoBehaviour
{
    public float throwForce = 20f;
    public GameObject ImpactPrefab;
    public Transform Impactout;
    public bool stay = false;

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning(stay);
        if (Input.GetKeyDown(KeyCode.G) && stay ==false)
        {
           
            ThrowGrenade();
            StartCoroutine(WaitForImpact());
        }
        
    }
    public void ThrowGrenade()
    {
        GameObject Impact =Instantiate(ImpactPrefab, Impactout.position, transform.rotation);
        Rigidbody rb = Impact.GetComponent<Rigidbody>();
        rb.AddForce(Impactout.forward * throwForce, ForceMode.VelocityChange);
        stay = true;
        
    }

    private IEnumerator WaitForImpact()
    {


        
        yield return new WaitForSeconds(5f);
        stay = false;
    }


}


