using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class WeaponUnityInstanceService : WeaponInstanceService
    {
        private readonly WeaponFactory _weaponFactory;

        public WeaponUnityInstanceService(WeaponFactory weaponFactory)
        {
            _weaponFactory = weaponFactory;
        }

        public int GetInstance(WeaponConfiguration weaponConfiguration, WeaponViewModel weaponViewModel)
        {
            var weaponView = _weaponFactory.Create(weaponConfiguration);

            weaponView.Configure(weaponViewModel);
           
            return weaponView.GetInstanceID();
        }


    }
}
