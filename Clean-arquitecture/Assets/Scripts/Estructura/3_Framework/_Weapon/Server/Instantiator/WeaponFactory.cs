using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Utils;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class WeaponFactory
    {
        private readonly WeaponPrefabCollection _weaponPrefabCollection;

        public WeaponFactory(WeaponPrefabCollection weaponsConfiguration)
        {
            _weaponPrefabCollection = weaponsConfiguration;
        }


        public WeaponView Create(WeaponConfiguration weaponConfiguration)
        {
            var prefab = _weaponPrefabCollection.GetHeroById(weaponConfiguration.Id);
            var position = weaponConfiguration.Position.ToUnity();

            WeaponBuilder weaponBuilder = new WeaponBuilder();
            weaponBuilder.WithID(weaponConfiguration.Id);
            weaponBuilder.WithPrefab(prefab);
            weaponBuilder.WithPosition(position);
            weaponBuilder.WithRotation(Quaternion.identity);

            return weaponBuilder.Build();
        }
    }
}
