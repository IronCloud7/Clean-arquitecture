using Assets.Scripts.Estructura._1_Aplication.UseCases;
using Assets.Scripts.Estructura.Framework;
using Assets.Scripts.Estructura.Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts
{
    class Installer : MonoBehaviour
    {
        [SerializeField] private Input _input;
        [SerializeField] private WeaponView _weaponView;
        [SerializeField] private HeroView _heroView;
        [SerializeField] private UnityDataService _unityService;

        public void Awake()
        {
             InputModel inputModel = new InputModel();

            //Weapon      
            WeaponViewModel weaponViewModel = new WeaponViewModel();
            WeaponPresenter weaponPresenter = new WeaponPresenter(weaponViewModel);
            WeaponGateway weaponGateway = new WeaponGatewayImp(_unityService);

            Attacker attackUseCase = new AttackUseCase(weaponPresenter, weaponGateway);

            //Hero
            HeroViewModel heroViewModel = new HeroViewModel();
            HeroPresenter heroPresenter = new HeroPresenter(heroViewModel);

            Mover moveUseCase = new MoveUseCase(heroPresenter);
            Jumper jumpUseCase = new JumpUseCase(heroPresenter);
            InputController inputController = new InputController(inputModel, attackUseCase, moveUseCase, jumpUseCase);

            //Asignar inputModel al input
            _input.Configure(inputModel);

            //Asignar viewModels a las views
            _weaponView.Configure(weaponViewModel);
            _heroView.Configure(heroViewModel);
        }
    }

}
