using UnityEngine;

namespace Assets.Scripts
{
    class Installer : MonoBehaviour
    {
        [SerializeField] private Input _input;
        [SerializeField] private View _view;

        public void Awake()
        {
             ViewModel viewModel = new ViewModel();

            _input.Configure(viewModel);
            _view.Configure(viewModel);

            InputPresenter inputPresenter = new InputPresenter(viewModel);

            Attacker AttackUseCase = new AttackUseCase(inputPresenter);
            Attacker AttackUseCase2 = new AttackUseCase(inputPresenter);

            InputController inputController = new InputController(viewModel, AttackUseCase);
            //InputPresenter inputPresenter = new InputPresenter(viewModel, AttackUseCase);

        }
    }

}
