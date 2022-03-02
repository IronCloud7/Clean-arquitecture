namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponDataGatewayImp :  WeaponDataGateway
    {
        private WeaponDataService _weaponDataService;

        public WeaponDataGatewayImp(WeaponDataService weaponDataService)
        {
            _weaponDataService = weaponDataService;
        }

        public WeaponDto GetWeapon(string id)
        {      
            var weaponRaw = _weaponDataService.GetWeapon(id);

            var weaponDto = new WeaponDto();
            weaponDto.Id = weaponRaw.Id;
            weaponDto.Name = weaponRaw.Name;
            weaponDto.Damage = weaponRaw.Damage;
            weaponDto.AttackRange = weaponRaw.AttackRange;
            weaponDto.SecondsBetweenAttacks = weaponRaw.SecondsBetweenAttacks;

            return weaponDto;
        }
    }
}
