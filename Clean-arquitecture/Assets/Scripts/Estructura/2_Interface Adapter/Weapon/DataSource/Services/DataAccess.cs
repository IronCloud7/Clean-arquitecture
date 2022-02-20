using Assets.Scripts.Estructura._2_Interface_Adapter.Weapon.Dto;

namespace Assets.Scripts.Estructura._2_Interface_Adapter.Weapon.DataSource.Services
{
    public interface DataAccess
    {
        public WeaponDto GetWeapon(string id);
    }
}
