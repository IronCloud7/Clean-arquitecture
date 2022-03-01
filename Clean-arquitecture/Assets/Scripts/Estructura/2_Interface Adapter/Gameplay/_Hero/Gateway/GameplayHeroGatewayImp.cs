using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._3_Framework;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class GameplayHeroGatewayImp : GameplayHeroGateway
    {
        GameplayHeroDataService _gameplayHeroDataService;

        public GameplayHeroGatewayImp(GameplayHeroDataService gameplayHeroDataService)
        {
            _gameplayHeroDataService = gameplayHeroDataService;
        }

        public GameplayHero GetInstance(HeroConfiguration heroConfiguration)
        {
            var heroViewModel = new HeroViewModel(heroConfiguration.Id);
            var heroPresenter = new HeroPresenter(heroViewModel);

            var instanceId = _gameplayHeroDataService.GetInstance(heroConfiguration, heroViewModel);
            var gameplayHero = new GameplayHero(heroConfiguration.Hero, instanceId, heroConfiguration.Position);

            var moveUseCase = new MoveUseCase(gameplayHero, heroPresenter);
            var jumpUseCase = new JumpUseCase(gameplayHero, heroPresenter);
            var attackUseCase = new AttackUseCase(gameplayHero, heroPresenter);
            var heroController = new HeroController(heroViewModel, moveUseCase, jumpUseCase, attackUseCase);
       
            return gameplayHero;
        }
    }


}
