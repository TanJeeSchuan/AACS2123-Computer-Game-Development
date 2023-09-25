using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Weapon;

public class EquipmentList : MonoBehaviour
{
    public List<WeaponBaseClass> weaponList;
    private int weaponIndex = 0;
    
    public WeaponBaseClass getFirstWeapon()
    {
        return weaponList[0];
    }
    
    public WeaponBaseClass cycleWeapon()
    {
        weaponIndex++;
        
        if (weaponIndex >= weaponList.Count)
            weaponIndex = 0;
        
        Debug.Log("Weapon Cycled Index: " + weaponIndex);

        return weaponList[weaponIndex];
    }

    public WeaponBaseClass getCurrentWeapon()
    {
        return weaponList[weaponIndex];
    }
}
