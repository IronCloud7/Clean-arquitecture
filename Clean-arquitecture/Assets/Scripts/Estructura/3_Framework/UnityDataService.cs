using Assets.Scripts.Estructura.Interface_Adapter.DataSource;
using Assets.Scripts.Estructura.Interface_Adapter.Dto.Weapons;
using UnityEngine;

namespace Assets.Scripts.Estructura.Framework
{
    class UnityDataService : MonoBehaviour, LocalDataAccess
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
