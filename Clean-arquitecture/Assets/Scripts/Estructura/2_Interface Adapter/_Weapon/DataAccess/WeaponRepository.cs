using Assets.Scripts.Estructura._1_Aplication;
using System.Collections.Generic;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponRepository : WeaponDataAccess
    {
        private readonly WeaponGateway _weaponGateway;
        private Dictionary<string, Weapon> _weapons;

        public WeaponRepository(WeaponGateway weaponGateway)
        {
            _weaponGateway = weaponGateway;

            _weapons = new Dictionary<string, Weapon>();
        }

        public Weapon GetWeapon(string id)
        {
            Weapon weapon;

            if (_weapons.TryGetValue(id, out weapon))
            {
                return weapon;
            } 
            
            var weaponDto = _weaponGateway.GetWeapon(id);

            weapon = new Weapon();
            weapon.Id = weaponDto.Id;
            weapon.Nombre = weaponDto.Nombre;
            weapon.Danyo = weaponDto.Danyo;

            _weapons.Add(weapon.Id, weapon);

            return weapon;
        }
    }
}
