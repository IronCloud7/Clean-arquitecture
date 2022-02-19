using Assets.Scripts.Estructura.Interface_Adapter.DataSource;
using Assets.Scripts.Estructura.Interface_Adapter.Dto.Weapons;
using UnityEngine;

namespace Assets.Scripts.Estructura.Framework
{
    class UnityService : MonoBehaviour, LocalDataAccess
    {
        [SerializeField] private WeaponData _weaponData;

        public WeaponDto GetWeapon(string id)
        {
            var weaponDto = new WeaponDto();

            weaponDto.Id = _weaponData.Id;
            weaponDto.Nombre = _weaponData.Nombre;
            weaponDto.Danyo = _weaponData.Danyo;

            return weaponDto;
        }
    }
}
