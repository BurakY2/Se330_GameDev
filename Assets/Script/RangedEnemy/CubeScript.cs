using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Vector3 goal;
    protected float Animation ;
    private PlayerHeal playerheal;
    private float time;

    
    // Start is called before the first frame update
    void Start()
    {
        goal = GameObject.FindGameObjectWithTag("GroundCheck").transform.position;
        playerheal = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHeal>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Animation += Time.deltaTime;
        Animation = Animation %5f ;
        transform.position = MathParabola.Parabola(ShooterScript.initialPoint,goal,5f,Animation/2f);
        if (time > 4.95f)
        {
            Destroy(gameObject);
        }
        
    }

     private void OnTriggerEnter(Collider other)
    {
          if (other.gameObject.tag == "Player")
        {
            Debug.Log("Enemy Atacking");
            playerheal.PlayerHealth -= 20f;
            Destroy(gameObject);
        }

        
    }
}
