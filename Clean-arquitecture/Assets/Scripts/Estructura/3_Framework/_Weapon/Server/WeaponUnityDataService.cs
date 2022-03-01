using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class WeaponUnityDataService : MonoBehaviour, WeaponDataService
    {
        [SerializeField] private WeaponsData _weaponsData;

        public void Awake()
        {
            _weaponsData = Instantiate(_weaponsData);
        }

        public WeaponResult GetWeapon(string id)
        {
            var weaponData = _weaponsData.GetWeaponById(id);

            var weaponResult = new WeaponResult();
            weaponResult.Id = weaponData.Id;
            weaponResult.Name = weaponData.Name;
            weaponResult.Damage = weaponData.Damage;
            weaponResult.AttackRange = weaponData.AttackRange;
            weaponResult.SecondsBetweenAttacks = weaponData.SecondsBetweenAttacks;


            return weaponResult;
        }
    }
}
