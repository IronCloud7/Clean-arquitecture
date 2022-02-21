using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class WeaponUnityService : MonoBehaviour, WeaponService
    {
        [SerializeField] private WeaponsData _weaponsData;

        public void Awake()
        {
            _weaponsData = Instantiate(_weaponsData);
        }

        public WeaponDto GetWeapon(string id)
        {
            var weaponData = _weaponsData.GetWeaponById(id);

            var weaponDto = new WeaponDto();
            weaponDto.Id = weaponData.Id;
            weaponDto.Nombre = weaponData.Nombre;
            weaponDto.Danyo = weaponData.Danyo;

            return weaponDto;
        }
    }
}
