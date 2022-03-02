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

        public Hero GetInstance(HeroConfiguration heroConfiguration)
        {
            var heroViewModel = new HeroViewModel(heroConfiguration.Id);
            var heroPresenter = new HeroPresenter(heroViewModel);

            var instanceId = _heroInstanceService.GetInstance(heroConfiguration, heroViewModel);
            var hero = new Hero(heroConfiguration.Hero, instanceId, heroConfiguration.Position);

            var moveUseCase = new MoveUseCase(hero, heroPresenter);
            var jumpUseCase = new JumpUseCase(hero, heroPresenter);
            var attackUseCase = new AttackUseCase(hero, heroPresenter);
            var heroController = new HeroController(heroViewModel, moveUseCase, jumpUseCase, attackUseCase);
       
            return hero;
        }
    }


}
