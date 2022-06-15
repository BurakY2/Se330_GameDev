using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssultRifle : MonoBehaviour
{
    public Camera camera;
    public float damage = 40;
    public ParticleSystem muzzleFlash;
    public LayerMask _layer;
    public static int ammo = 30;



    // Start is called before the first frame update
    void Start()
    {
        //muzzleFlash.Stop();
        muzzleFlash.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            
        }
        if (Input.GetButtonUp("Fire1"))
        {
            muzzleFlash.Stop();
            
        }
        
    }

    public void Shoot()
    {
        if(ammo > 0)
        {
            muzzleFlash.Play();
            RaycastHit hitObject;
            if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hitObject, Mathf.Infinity, _layer, QueryTriggerInteraction.Ignore))
            {
                Debug.Log(hitObject.transform.name);
                EnemyHealth target = hitObject.transform.GetComponent<EnemyHealth>();
                if (target != null)
                {
                    target.hitByPlayer(damage);
                }
            }
            ammo -= 1;
            if (ammo <= 0)
            {
                StartCoroutine(reload());
            }
        }
       
    }
    IEnumerator reload()
    {
        Debug.Log("reloading");
        yield return new WaitForSeconds(3f);
        ammo = 30;
    }
}
