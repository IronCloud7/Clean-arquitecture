using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Estructura._3_Framework;
using UnityEngine;
using Input = Assets.Scripts.Estructura._3_Framework.Input;

namespace Assets.Scripts
{
    public class Level01Installer : MonoBehaviour
    {
        [SerializeField] HeroInstaller _heroInstaller;
        [SerializeField] MenuInstaller _menuInstaller;

        [SerializeField] private Input _input;
        [SerializeField] private GroundCheck _groundCollisionDetector;

        public void Start()
        {
            InputModel inputModel = new InputModel();
            _input.Configure(inputModel);

            GroundModel groundModel = new GroundModel();
            GroundGateway groundGateway = new GroundGatewayImp(groundModel);

            _groundCollisionDetector.Configure(groundModel);

            HeroDataAccess heroRepository = ServiceLocator.Instance.GetService<HeroDataAccess>();
            HealthDataAccess healthRepository = ServiceLocator.Instance.GetService<HealthDataAccess>();
            WeaponDataAccess weaponRepository = ServiceLocator.Instance.GetService<WeaponDataAccess>();

            GameStateController gameStateController = new GameStateController(inputModel);
     
            _heroInstaller.Configure(inputModel, groundGateway);
            _heroInstaller.Initialize();

            _menuInstaller.Configure(inputModel, weaponRepository, healthRepository);
            _menuInstaller.Initialize();

        }
    }

}
