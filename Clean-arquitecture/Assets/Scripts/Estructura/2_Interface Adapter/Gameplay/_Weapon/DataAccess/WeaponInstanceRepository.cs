using Assets.Scripts.Estructura._1_Aplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponInstanceRepository : WeaponInstanceAccess
    {
        private readonly WeaponInstanceGateway _weaponInstanceGateway;
        private readonly Dictionary<int, Weapon> _weapons;

        public WeaponInstanceRepository(WeaponInstanceGateway weaponInstanceGateway)
        {
            _weaponInstanceGateway = weaponInstanceGateway;
            _weapons = new Dictionary<int, Weapon>();
        }

        public void Add(WeaponData weaponData, Vector3 posicion = default)
        {       
            var spawnPosition = posicion;
            var weaponConfiguration = new WeaponConfiguration(weaponData, spawnPosition);
       
            var weapon = _weaponInstanceGateway.GetInstance(weaponConfiguration);

            _weapons.Add(weapon.InstanceId, weapon);
        }

        public Weapon Get(int InstanceId)
        {
            Weapon weapon;

            if (!_weapons.TryGetValue(InstanceId, out weapon))
            {
                throw new ArgumentOutOfRangeException($"Weapon with Id {InstanceId} does not exist");
            }

            return weapon;
        }

        public void Remove(int InstanceId)
        {

            if (!_weapons.Remove(InstanceId))
            {
                throw new ArgumentOutOfRangeException($"Weapon with Id {InstanceId} does not exist");
            }
        }

        public IReadOnlyList<Weapon> GetAll()
        {         
            return _weapons.Values.ToList<Weapon>();
        }
    }
}
