using Assets.Scripts.Estructura._1_Aplication.Weapon.Gateway;
using Assets.Scripts.Estructura._2_Interface_Adapter.Weapon.DataSource.Services;

namespace Assets.Scripts.Estructura._2_Interface_Adapter.Weapon.DataSource
{
    public class WeaponGatewayImp : WeaponGateway
    {
        private DataAccess _dataAccess;

        public WeaponGatewayImp(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public _1_Aplication.Weapon.Entity.Weapon GetWeapon(string id)
        {
            var weaponDto = _dataAccess.GetWeapon(id);
            var weapon = new _1_Aplication.Weapon.Entity.Weapon();

            weapon.Id = weaponDto.Id;
            weapon.Nombre = weaponDto.Nombre;
            weapon.Danyo = weaponDto.Danyo;

            return weapon;
        }
    }
}
