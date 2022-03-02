using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    [CreateAssetMenu(menuName = "Custom/Weapon/Data/Collection", fileName = "Weapon Collection")]
    public class WeaponUnityCollection : ScriptableObject
    {
        [SerializeField] private WeaponUnity[] _weapons;
        private Dictionary<string, WeaponUnity> _idToWeapon;

        public WeaponUnity[] Weapons => _weapons;

        public void Awake()
        {
            _idToWeapon = new Dictionary<string, WeaponUnity>();
            foreach (var weapon in _weapons)
            {
                _idToWeapon.Add(weapon.Id, weapon);
            }
        }

        public WeaponUnity GetWeaponById(string id)
        {
            if (!_idToWeapon.TryGetValue(id, out var weaponUnityData))
            {
                throw new ArgumentOutOfRangeException($"Weapon with Id {id} does not exist");
            }

            return weaponUnityData;
        }

    }
}
