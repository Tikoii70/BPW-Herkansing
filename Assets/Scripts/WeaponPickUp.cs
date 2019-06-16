using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    public GameObject myWeapon;
    public GameObject weaponOnGround;
    // Start is called before the first frame update
    void Start()
    {
        myWeapon.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        myWeapon.SetActive(true);
        weaponOnGround.SetActive(false);
    }
}
