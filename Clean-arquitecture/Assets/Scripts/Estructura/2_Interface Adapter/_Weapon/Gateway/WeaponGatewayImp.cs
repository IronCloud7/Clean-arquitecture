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
            var weaponResult = _weaponDataService.GetWeapon(id);

            var weaponDto = new WeaponDto();
            weaponDto.Id = weaponResult.Id;
            weaponDto.Nombre = weaponResult.Nombre;
            weaponDto.Danyo = weaponResult.Danyo;

            return weaponDto;
        }
    }
}
