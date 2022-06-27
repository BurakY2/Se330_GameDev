using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject AmmoText1_, AmmoText2_;
    public Text AmmoText;
    public Text AmmoText2;
    public static bool secondGunFlag = false;
    public GameObject firstGun;
    public GameObject SecondGun;
    private void Start()
    {
        AmmoText1_.SetActive(true);
        AmmoText2_.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        AmmoText.text = "Ammo : " + (AssultRifle.ammo).ToString();
        AmmoText2.text = "Ammo : " + (AssulfRifle2.ammo).ToString();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SecondGun.SetActive(false);
            firstGun.SetActive(true);
            AmmoText1_.SetActive(true);
            AmmoText2_.SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && secondGunFlag)
        {
            firstGun.SetActive(false);
            SecondGun.SetActive(true);
            AmmoText1_.SetActive(false);
            AmmoText2_.SetActive(true);
        }
    }

    
}
