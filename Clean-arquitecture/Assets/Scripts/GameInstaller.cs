using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Estructura._3_Framework;
using UnityEngine;
using UnityInputAdapter = Assets.Scripts.Estructura._3_Framework.UnityInputAdapter;

namespace Assets.Scripts
{
    public class GameInstaller : MonoBehaviour
    {
        //[SerializeField] MenuInstaller _menuInstaller;

        //[SerializeField] private UnityInputAdapter _input;
        //[SerializeField] private GroundCheck _groundCollisionDetector;

        [SerializeField] private HeroesConfiguration _herosConfiguration;

        public void Start()
        {
            //GroundModel groundModel = new GroundModel();
            //GroundGateway groundGateway = new GroundGatewayImp(groundModel);

            //_groundCollisionDetector.Configure(groundModel);

            HeroDataAccess heroRepository = ServiceLocator.Instance.GetService<HeroDataAccess>();
            HealthDataAccess healthRepository = ServiceLocator.Instance.GetService<HealthDataAccess>();
            WeaponDataAccess weaponRepository = ServiceLocator.Instance.GetService<WeaponDataAccess>();

            //GameStateController gameStateController = new GameStateController(inputModel);
     
            //_heroInstaller.Configure(inputModel, groundGateway);
            //_heroInstaller.Initialize();

            //_menuInstaller.Configure(inputModel, weaponRepository, healthRepository);
            //_menuInstaller.Initialize();

            //EventDispatcherService eventDispatcherService = ServiceLocator.Instance.GetService<EventDispatcherService>();

            //var heroPresentersContainer = new HeroPresentersContainer(eventDispatcherService);

            _herosConfiguration = Instantiate(_herosConfiguration);
            HeroFactory heroFactory = new HeroFactory(_herosConfiguration);
            GameplayHeroDataService gameplayHeroDataService = new GameplayHeroUnityDataService(heroFactory);
            GameplayHeroGateway gameplayHeroGatewayImp = new GameplayHeroGatewayImp(gameplayHeroDataService);
            GameplayHeroDataAccess gameplayHeroRepository = new GameplayHeroRepository(gameplayHeroGatewayImp);
            HeroSpawner heroSpawner = new HeroSpawnUseCase(heroRepository, gameplayHeroRepository);

            ServiceLocator.Instance.RegisterService<GameplayHeroDataAccess>(gameplayHeroRepository);

            heroSpawner.Spawn("Hero");
            heroSpawner.Spawn("Enemy");
        }
    }

}
