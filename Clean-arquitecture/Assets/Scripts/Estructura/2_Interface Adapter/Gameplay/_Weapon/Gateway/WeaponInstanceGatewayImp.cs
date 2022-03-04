using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._3_Framework;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponInstanceGatewayImp : WeaponInstanceGateway
    {
        WeaponInstanceService _weaponInstanceService;

        public WeaponInstanceGatewayImp(WeaponInstanceService weaponInstanceService)
        {
            _weaponInstanceService = weaponInstanceService;
        }

        public Weapon GetInstance(WeaponConfiguration weaponConfiguration)
        {
            var weaponViewModel = new WeaponViewModel(weaponConfiguration);
            var weaponPresenter = new WeaponPresenter(weaponViewModel);

            var instanceId = _weaponInstanceService.GetInstance(weaponConfiguration, weaponViewModel);
            var weapon = new Weapon(weaponConfiguration.WeaponData, instanceId, weaponConfiguration.Position);

            //var moveUseCase = new MoveUseCase(weapon, weaponPresenter);
            //var jumpUseCase = new JumpUseCase(weapon, weaponPresenter);
            //var attackUseCase = new AttackUseCase(weapon, weaponPresenter);
            //var heroController = new HeroController(weaponViewModel, moveUseCase, jumpUseCase, attackUseCase);

            return weapon;
        }
    }


}
