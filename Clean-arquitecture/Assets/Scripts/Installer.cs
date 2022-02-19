using Assets.Scripts.Estructura.Framework;
using UnityEngine;

namespace Assets.Scripts
{
    class Installer : MonoBehaviour
    {
        [SerializeField] private Input _input;
        [SerializeField] private View _view;
        [SerializeField] private UnityService _unityService;

        public void Awake()
        {
             ViewModel viewModel = new ViewModel();

            _input.Configure(viewModel);
            _view.Configure(viewModel);

            WeaponGateway weaponGateway = new WeaponGatewayImp(_unityService);
            InputPresenter inputPresenter = new InputPresenter(viewModel);

            Attacker AttackUseCase = new AttackUseCase(inputPresenter, weaponGateway);

            InputController inputController = new InputController(viewModel, AttackUseCase);
        }
    }

}
