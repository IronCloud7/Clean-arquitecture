using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._3_Framework;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroInstanceGatewayImp : HeroInstanceGateway
    {
        HeroInstanceService _heroInstanceService;

        public HeroInstanceGatewayImp(HeroInstanceService heroInstanceService)
        {
            _heroInstanceService = heroInstanceService;
        }

        public Hero GetInstance(HeroConfiguration heroConfiguration, WeaponConfiguration weaponConfiguration)
        {
            var heroViewModel = new HeroViewModel(heroConfiguration);
            var heroPresenter = new HeroPresenter(heroViewModel);

            var weaponViewModel = new WeaponViewModel(weaponConfiguration);
            var weaponPresenter = new WeaponPresenter(weaponViewModel);

            var idToInstanceId = _heroInstanceService.GetInstance(heroConfiguration, heroViewModel, 
                                                            weaponConfiguration, weaponViewModel);


            var hero = new Hero(heroConfiguration.HeroData, idToInstanceId[heroConfiguration.Id], heroConfiguration.Position);
            var weapon = new Weapon(weaponConfiguration.WeaponData, idToInstanceId[weaponConfiguration.Id], weaponConfiguration.Position);

            hero.SetWeapon(weapon);

            var moveUseCase = new MoveUseCase(hero, heroPresenter);
            var jumpUseCase = new JumpUseCase(hero, heroPresenter);
            var attackUseCase = new AttackUseCase(hero, heroPresenter, weaponPresenter);
            var heroController = new HeroController(heroViewModel, moveUseCase, jumpUseCase, attackUseCase);
             
            return hero;
        }
    }


}
