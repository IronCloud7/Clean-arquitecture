using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._1_Aplication.UseCases;
using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Estructura._3_Framework;
using Assets.Scripts.Utils;
using UnityEngine;

namespace Assets.Scripts
{
    public class GlobalInstaller : MonoBehaviour
    {
        [SerializeField] private MainMenuView _mainMenuView;

        [SerializeField] private HeroUnityDataService _heroService;
        [SerializeField] private HealthUnityDataService _healthService;
        [SerializeField] private WeaponUnityDataService _weaponService;

        public void Awake()
        {
            InitializeDataServices();
        }

        public void InitializeDataServices()
        {
            HeroDataGateway heroGateway = new HeroDataGatewayImp(_heroService);
            HeroDataAccess heroRepository = new HeroDataRepository(heroGateway);

            HealthGateway healthGateway = new HealthGatewayImp(_healthService);
            HealthDataAccess healthRepository = new HealthRepository(healthGateway);

            WeaponDataGateway weaponGateway = new WeaponDataGatewayImp(_weaponService);
            WeaponDataAccess weaponRepository = new WeaponDataRepository(weaponGateway);

            ServiceLocator.Instance.RegisterService<HeroDataAccess>(heroRepository);
            ServiceLocator.Instance.RegisterService<HealthDataAccess>(healthRepository);
            ServiceLocator.Instance.RegisterService<WeaponDataAccess>(weaponRepository);

        }
    }

}
