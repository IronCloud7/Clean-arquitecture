using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Weapon Configurations")]
public class WeaponConfigurations : ScriptableObject
{
    [SerializeField] private WeaponData[] _weapons;
    private Dictionary<string, WeaponData> _idToWeapon;

    public WeaponData[] Weapons => _weapons;

    public void Awake()
    {
        _idToWeapon = new Dictionary<string, WeaponData>();
        foreach (var weapon in _weapons)
        {
            _idToWeapon.Add(weapon.Id, weapon);
        }
    }

    public WeaponData GetWeaponById(string id)
    {
        if (!_idToWeapon.TryGetValue(id, out var weaponData))
        {
            throw new ArgumentOutOfRangeException($"Weapon with Id {id} does not exist");
        }

        return weaponData;
    }

}
