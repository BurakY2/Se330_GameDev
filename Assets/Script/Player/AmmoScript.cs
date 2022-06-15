using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text AmmoText;

    // Update is called once per frame
    void Update()
    {
        AmmoText.text = "Ammo : " + (AssultRifle.ammo).ToString();
    }
}
