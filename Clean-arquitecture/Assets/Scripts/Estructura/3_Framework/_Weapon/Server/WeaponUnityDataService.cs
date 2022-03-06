using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class WeaponUnityDataService : MonoBehaviour, WeaponDataService
    {
        [SerializeField] private WeaponUnityCollection _weaponsData;

        public void Awake()
        {
            _weaponsData = Instantiate(_weaponsData);
        }

        public WeaponRaw GetWeapon(string id)
        {
            var weaponUnity = _weaponsData.GetWeaponById(id);

            var weaponRaw = new WeaponRaw();
            weaponRaw.Id = weaponUnity.Id;
            weaponRaw.Name = weaponUnity.Name;
            weaponRaw.Damage = weaponUnity.Damage;
            weaponRaw.AttackRange = weaponUnity.AttackRange;
            weaponRaw.PenetrationRange = weaponUnity.PenetrationRange;
            weaponRaw.SecondsBetweenAttacks = weaponUnity.SecondsBetweenAttacks;


            return weaponRaw;
        }
    }
}
