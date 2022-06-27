using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text AmmoText;
    public static bool secondGunFlag = false;
    public GameObject firstGun;
    public GameObject SecondGun;

    // Update is called once per frame
    void Update()
    {
        AmmoText.text = "Ammo : " + (AssultRifle.ammo).ToString();
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SecondGun.SetActive(false);
            firstGun.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && secondGunFlag)
        {
            firstGun.SetActive(false);
            SecondGun.SetActive(true);  
        }
    }

    
}
