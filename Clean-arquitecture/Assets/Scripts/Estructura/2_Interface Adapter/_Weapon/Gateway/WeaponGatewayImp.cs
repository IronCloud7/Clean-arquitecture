using Assets.Scripts.Estructura._3_Framework;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponGatewayImp :  WeaponGateway
    {
        private WeaponDataService _weaponDataService;

        public WeaponGatewayImp(WeaponDataService weaponDataService)
        {
            _weaponDataService = weaponDataService;
        }

        public WeaponDto GetWeapon(string id)
        {      
            var weaponDto = _weaponDataService.GetWeapon(id);

            return weaponDto;
        }
    }
}
