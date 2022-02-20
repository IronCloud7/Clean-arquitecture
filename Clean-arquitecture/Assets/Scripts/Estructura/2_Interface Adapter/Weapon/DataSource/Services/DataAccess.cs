using Assets.Scripts.Estructura.Interface_Adapter.Dto.Weapons;

namespace Assets.Scripts.Estructura.Interface_Adapter.Weapons.DataSource.Services
{
    public interface DataAccess
    {
        public WeaponDto GetWeapon(string id);
    }
}
