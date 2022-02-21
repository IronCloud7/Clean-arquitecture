using Assets.Scripts.Estructura._1_Aplication;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponRepository : WeaponDataAccess
    {
        private WeaponGateway _weaponGateway;

        public WeaponRepository(WeaponGateway weaponGateway)
        {
            _weaponGateway = weaponGateway;
        }

        public Weapon GetWeapon(string id)
        {
            var weaponDto = _weaponGateway.GetWeapon(id);
            var weapon = new Weapon();

            weapon.Id = weaponDto.Id;
            weapon.Nombre = weaponDto.Nombre;
            weapon.Danyo = weaponDto.Danyo;

            return weapon;
        }
    }
}
