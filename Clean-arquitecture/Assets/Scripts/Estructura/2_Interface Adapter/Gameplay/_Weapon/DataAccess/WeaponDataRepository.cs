using Assets.Scripts.Estructura._1_Aplication;
using System.Collections.Generic;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponDataRepository : WeaponDataAccess
    {
        private readonly WeaponDataGateway _weaponDataGateway;
        private Dictionary<string, WeaponData> _weaponsData;

        public WeaponDataRepository(WeaponDataGateway weaponDataGateway)
        {
            _weaponDataGateway = weaponDataGateway;

            _weaponsData = new Dictionary<string, WeaponData>();
        }

        public WeaponData GetWeapon(string id)
        {
            WeaponData weaponData;

            if (_weaponsData.TryGetValue(id, out weaponData))
            {
                return weaponData;
            } 
            
            var weaponDto = _weaponDataGateway.GetWeapon(id);

            weaponData = new WeaponData();
            weaponData.Id = weaponDto.Id;
            weaponData.Name = weaponDto.Name;
            weaponData.Attributes.Damage = weaponDto.Damage;
            weaponData.Attributes.AttackRange = weaponDto.AttackRange;
            weaponData.Attributes.PenetrationRange = weaponDto.PenetrationRange;
            weaponData.Attributes.SecondsBetweenAttacks = weaponDto.SecondsBetweenAttacks;

            _weaponsData.Add(weaponData.Id, weaponData);

            return weaponData;
        }
    }
}
