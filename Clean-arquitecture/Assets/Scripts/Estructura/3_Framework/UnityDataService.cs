using Assets.Scripts.Estructura._2_Interface_Adapter.Weapon.DataSource.Services;
using Assets.Scripts.Estructura._2_Interface_Adapter.Weapon.Dto;
using Assets.Scripts.Estructura._3_Framework.Weapon.Data;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class UnityDataService : MonoBehaviour, LocalDataAccess
    {
        [SerializeField] private WeaponConfigurations _weaponsData;

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
