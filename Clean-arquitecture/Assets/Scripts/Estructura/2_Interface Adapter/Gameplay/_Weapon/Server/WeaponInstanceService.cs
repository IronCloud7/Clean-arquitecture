using Assets.Scripts.Estructura._2_Interface_Adapter;

namespace Assets.Scripts.Estructura._3_Framework
{
    public interface WeaponInstanceService
    {
        public int GetInstance(WeaponConfiguration weaponConfiguration, WeaponViewModel weaponViewModel);
    }
}
