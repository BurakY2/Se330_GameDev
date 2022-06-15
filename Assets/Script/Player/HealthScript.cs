using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public Text HealthText;
    public PlayerHeal PlayerHeal;
    // Update is called once per frame
    void Update()
    {
        HealthText.text = "Health : " + (PlayerHeal.PlayerHealth).ToString();
    }
}
