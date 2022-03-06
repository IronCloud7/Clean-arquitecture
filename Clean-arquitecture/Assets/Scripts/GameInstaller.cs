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
        [SerializeField] private WeaponPrefabCollection _weaponPrefabCollection;
        public void Start()
        {
            HeroDataAccess heroRepository = ServiceLocator.Instance.GetService<HeroDataAccess>();
            HealthDataAccess healthRepository = ServiceLocator.Instance.GetService<HealthDataAccess>();
            WeaponDataAccess weaponRepository = ServiceLocator.Instance.GetService<WeaponDataAccess>();

            //GameStateController gameStateController = new GameStateController(inputModel);

            _weaponPrefabCollection = Instantiate(_weaponPrefabCollection);
            WeaponFactory weaponFactory = new WeaponFactory(_weaponPrefabCollection);
            WeaponInstanceService weaponInstanceService = new WeaponUnityInstanceService(weaponFactory);
            WeaponInstanceGateway weaponInstanceGateway = new WeaponInstanceGatewayImp(weaponInstanceService);
            WeaponInstanceAccess weaponInstanceRepository = new WeaponInstanceRepository(weaponInstanceGateway);
            WeaponSpawner weaponSpawner = new WeaponSpawnUseCase(weaponRepository, weaponInstanceRepository);

            _heroPrefabCollection = Instantiate(_heroPrefabCollection);
            HeroFactory heroFactory = new HeroFactory(_heroPrefabCollection);
            HeroInstanceService heroInstanceService = new HeroUnityInstanceService(heroFactory, weaponFactory);
            HeroInstanceGateway heroInstanceGateway = new HeroInstanceGatewayImp(heroInstanceService);
            HeroInstanceAccess heroInstanceRepository = new HeroInstanceRepository(heroInstanceGateway, weaponInstanceGateway);
            HeroSpawner heroSpawner = new HeroSpawnUseCase(heroRepository, weaponRepository, heroInstanceRepository);


            ServiceLocator.Instance.RegisterService<HeroInstanceAccess>(heroInstanceRepository);
            ServiceLocator.Instance.RegisterService<WeaponInstanceAccess>(weaponInstanceRepository);

            ServiceLocator.Instance.RegisterService<HeroSpawner>(heroSpawner);
            ServiceLocator.Instance.RegisterService<WeaponSpawner>(weaponSpawner);

            heroSpawner.Spawn("Hero");
            //heroSpawner.Spawn("Enemy");
        }
    }

}
