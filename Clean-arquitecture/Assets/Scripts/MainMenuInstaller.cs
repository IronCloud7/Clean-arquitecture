using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Estructura._3_Framework;
using UnityEngine;
using Input = Assets.Scripts.Estructura._3_Framework.Input;

namespace Assets.Scripts
{
    public class MainMenuInstaller : MonoBehaviour
    {
        //[SerializeField] HeroInstaller _heroInstaller;
        //[SerializeField] MenuInstaller _menuInstaller;


        [SerializeField] private HeroUnityDataService _heroService;
        [SerializeField] private HealthUnityDataService _healthService;
        [SerializeField] private WeaponUnityDataService _weaponService;

        //[SerializeField] private Input _input;
        //[SerializeField] private GroundCollisionDetector _groundCollisionDetector;

        public void Awake()
        {
            //GroundModel groundModel = new GroundModel();
            //GroundGateway groundGateway = new GroundGatewayImp(groundModel);

            HeroGateway heroGateway = new HeroGatewayImp(_heroService);
            HeroDataAccess heroRepository = new HeroRepository(heroGateway);

            HealthGateway healthGateway = new HealthGatewayImp(_healthService);
            HealthDataAccess healthRepository = new HealthRepository(healthGateway);

            WeaponGateway weaponGateway = new WeaponGatewayImp(_weaponService);
            WeaponDataAccess weaponRepository = new WeaponRepository(weaponGateway);

            ServiceLocator.Instance.RegisterService(heroRepository);
            ServiceLocator.Instance.RegisterService(healthRepository);
            ServiceLocator.Instance.RegisterService(weaponRepository);
        }
    }

}
