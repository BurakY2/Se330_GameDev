using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroImpact : MonoBehaviour
{
    public EnemyController EnemyScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        StartCoroutine(DestoryImpact());
    }
    private IEnumerator DestoryImpact()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
        

    }
}
