using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Estructura._3_Framework;
using UnityEngine;
using Input = Assets.Scripts.Estructura._3_Framework.Input;

namespace Assets.Scripts
{
    public class MenuInstaller : MonoBehaviour
    {

        private InputModel _inputModel;
        private WeaponDataAccess _weaponRepository;
        private HealthDataAccess _healthRepository;

        private HealthRefresher _healthRefreshUseCase;
        private Attacker _attackUseCase;

        [SerializeField] private HealthView _healthView;
        [SerializeField] private WeaponView _weaponView;

        public void Configure(InputModel inputModel, WeaponDataAccess weaponRepository, HealthDataAccess healthRepository)
        {
            _inputModel = inputModel;
            _weaponRepository = weaponRepository;
            _healthRepository = healthRepository;
        }


        public void Initialize()
        {
            InitializeHealth();
            InitializeWeapon();

            MenuController menuController = new MenuController(_inputModel, _attackUseCase, _healthRefreshUseCase);
        }

        public void InitializeHealth()
        {
            HealthViewModel _healthViewModel = new HealthViewModel();
            HealthPresenter _healthPresenter = new HealthPresenter(_healthViewModel);

            _healthRefreshUseCase = new HealthRefreshUseCase(_healthPresenter, _healthRepository);
            _healthView.Configure(_healthViewModel);
        }

        public void InitializeWeapon()
        {
            WeaponViewModel weaponViewModel = new WeaponViewModel();
            WeaponPresenter weaponPresenter = new WeaponPresenter(weaponViewModel);

            _attackUseCase = new AttackUseCase(weaponPresenter, _weaponRepository);
            _weaponView.Configure(weaponViewModel);
        }
    }
    }
