using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._1_Aplication.UseCases;
using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Estructura._3_Framework;
using UnityEngine;
using Input = Assets.Scripts.Estructura._3_Framework.Input;

namespace Assets.Scripts
{
    public class MainMenuInstaller : MonoBehaviour
    {
        [SerializeField] private MainMenuView _mainMenuView;

        [SerializeField] private HeroUnityDataService _heroService;
        [SerializeField] private HealthUnityDataService _healthService;
        [SerializeField] private WeaponUnityDataService _weaponService;

        public void Awake()
        {
            //InitializeMenu();
            InitializeDataServices();
        }

        public void InitializeMenu()
        {
            //Uses cases
            StarterGame starterGame = new StartGameUseCase();

            //Estructure
            MainMenuViewModel mainMenuViewModel = new MainMenuViewModel();
            MainMenuController mainMenuController = new MainMenuController(mainMenuViewModel, starterGame);

            _mainMenuView.Configure(mainMenuViewModel);
        }


        public void InitializeDataServices()
        {
            HeroGateway heroGateway = new HeroGatewayImp(_heroService);
            HeroDataAccess heroRepository = new HeroRepository(heroGateway);

            HealthGateway healthGateway = new HealthGatewayImp(_healthService);
            HealthDataAccess healthRepository = new HealthRepository(healthGateway);

            WeaponGateway weaponGateway = new WeaponGatewayImp(_weaponService);
            WeaponDataAccess weaponRepository = new WeaponRepository(weaponGateway);

            ServiceLocator.Instance.RegisterService<HeroDataAccess>(heroRepository);
            ServiceLocator.Instance.RegisterService<HealthDataAccess>(healthRepository);
            ServiceLocator.Instance.RegisterService<WeaponDataAccess>(weaponRepository);
        }
    }

}
