using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeal : MonoBehaviour
{
    public float PlayerHealth = 100f;
    public GameObject cam;
    private void Start()
    {
        PlayerHealth = 100;
    }

    private void Update()
    {
        Debug.Log(PlayerHealth);

        if (PlayerHealth <= 0)
        {
            Destroy(gameObject);
            cam.SetActive(true);
        }
    }
}
