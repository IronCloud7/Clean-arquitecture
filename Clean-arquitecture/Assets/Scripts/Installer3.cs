using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Estructura._3_Framework;
using UnityEngine;
using Input = Assets.Scripts.Estructura._3_Framework.Input;

namespace Assets.Scripts
{
    public class Installer3 : MonoBehaviour
    {
        [SerializeField] HeroInstaller _heroInstaller;
        [SerializeField] MenuInstaller _menuInstaller;

        [SerializeField] private Input _input;
        [SerializeField] private GroundCollisionDetector _groundCollisionDetector;

        public void Awake()
        {
            GroundModel groundModel = new GroundModel();
            GroundGateway groundGateway = new GroundGatewayImp(groundModel);

            HeroDataAccess heroRepository = ServiceLocator.Instance.GetService<HeroDataAccess>();
            HealthDataAccess healthRepository = ServiceLocator.Instance.GetService<HealthDataAccess>();
            WeaponDataAccess weaponRepository = ServiceLocator.Instance.GetService<WeaponDataAccess>();

            InputModel inputModel = new InputModel();

            GameStateController gameStateController = new GameStateController(inputModel);

            _input.Configure(inputModel);
            _heroInstaller.Configure(inputModel, groundGateway);
            _menuInstaller.Configure(inputModel, weaponRepository, healthRepository);

            _heroInstaller.Initialize();
            _menuInstaller.Initialize();

            _groundCollisionDetector.Configure(groundModel);
        }
    }

}
