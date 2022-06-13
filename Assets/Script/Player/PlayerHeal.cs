using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeal : MonoBehaviour
{
    public float PlayerHealth = 100f;

    private void Update()
    {
        Debug.Log(PlayerHealth);
    }
}
