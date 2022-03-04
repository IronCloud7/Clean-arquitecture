using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    [CreateAssetMenu(menuName = "Custom/Weapon/Prefab/Collection", fileName = "Weapon Prefab Collection")]
    public class WeaponPrefabCollection : ScriptableObject
    {
        [SerializeField] private WeaponView[] _weapons;
        private Dictionary<int, WeaponView> _idToWeapon;

        public WeaponView[] Weapons => _weapons;

        public void Awake()
        {
            _idToWeapon = new Dictionary<int, WeaponView>(_weapons.Length);
            foreach (var weapon in _weapons)
            {
                _idToWeapon.Add(weapon.name.GetHashCode(), weapon);
            }
        }

        public WeaponView GetHeroById(string id)
        {
            if (!_idToWeapon.TryGetValue(id.GetHashCode(), out var weapon))
            {
                throw new ArgumentOutOfRangeException($"Weapon with Id {id} does not exist");
            }

            return weapon;
        }

    }
}
