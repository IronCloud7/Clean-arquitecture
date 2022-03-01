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
