using Assets.Scripts.Estructura._2_Interface_Adapter;
using System.Collections.Generic;

namespace Assets.Scripts.Estructura._3_Framework
{
    public interface HeroInstanceService
    {
        public Dictionary<string,int> GetInstance(HeroConfiguration heroConfiguration, HeroViewModel heroViewModel,
                                WeaponConfiguration weaponConfiguration, WeaponViewModel weaponViewModel);
    }
}
