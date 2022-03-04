using Assets.Scripts.Estructura._2_Interface_Adapter;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class HeroUnityInstanceService :  HeroInstanceService
    {
        private readonly HeroFactory _heroFactory;
        private readonly WeaponFactory _weaponFactory;

        private readonly Dictionary<string, int> IdToinstanceId;

        public HeroUnityInstanceService(HeroFactory heroFactory, WeaponFactory weaponFactory)
        {
            IdToinstanceId = new Dictionary<string, int>(2);

            _heroFactory = heroFactory;
            _weaponFactory = weaponFactory;
        }

        public Dictionary<string, int> GetInstance(HeroConfiguration heroConfiguration, HeroViewModel heroViewModel,
                             WeaponConfiguration weaponConfiguration, WeaponViewModel weaponViewModel)
        {
            var heroView = _heroFactory.Create(heroConfiguration);
            heroView.Configure(heroViewModel);

            var weaponView = _weaponFactory.Create(weaponConfiguration);
            weaponView.transform.parent = heroView.transform;
            weaponView.Configure(weaponViewModel);

            IdToinstanceId.Add(heroConfiguration.Id, heroView.GetInstanceID());
            IdToinstanceId.Add(weaponConfiguration.Id, weaponView.GetInstanceID());

            return IdToinstanceId;
        }

   
    }
}
