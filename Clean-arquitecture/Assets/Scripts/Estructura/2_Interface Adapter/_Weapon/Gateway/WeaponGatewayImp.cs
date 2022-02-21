using Assets.Scripts.Estructura._3_Framework;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponGatewayImp :  WeaponGateway
    {
        private WeaponService _weaponService;

        public WeaponGatewayImp(WeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        public WeaponDto GetWeapon(string id)
        {      
            var weaponDto = _weaponService.GetWeapon(id);

            return weaponDto;
        }
    }
}
