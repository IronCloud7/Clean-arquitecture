using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Estructura._3_Framework;
using UnityEngine;
using UnityInputAdapter = Assets.Scripts.Estructura._3_Framework.UnityInputAdapter;

namespace Assets.Scripts
{
    public class GameInstaller : MonoBehaviour
    {
        [SerializeField] private HeroPrefabCollection _heroPrefabCollection;

        public void Start()
        {
            HeroDataAccess heroRepository = ServiceLocator.Instance.GetService<HeroDataAccess>();
            HealthDataAccess healthRepository = ServiceLocator.Instance.GetService<HealthDataAccess>();
            WeaponDataAccess weaponRepository = ServiceLocator.Instance.GetService<WeaponDataAccess>();

            //GameStateController gameStateController = new GameStateController(inputModel);

            _heroPrefabCollection = Instantiate(_heroPrefabCollection);
            HeroFactory heroFactory = new HeroFactory(_heroPrefabCollection);
            HeroInstanceService heroInstanceService = new HeroUnityInstanceService(heroFactory);
            HeroInstanceGateway heroInstanceGateway = new HeroInstanceGatewayImp(heroInstanceService);
            HeroInstanceAccess heroInstanceRepository = new HeroInstanceRepository(heroInstanceGateway);
            HeroSpawner heroSpawner = new HeroSpawnUseCase(heroRepository, heroInstanceRepository);

            ServiceLocator.Instance.RegisterService<HeroInstanceAccess>(heroInstanceRepository);

            heroSpawner.Spawn("Hero");
            //heroSpawner.Spawn("Enemy");
        }
    }

}
