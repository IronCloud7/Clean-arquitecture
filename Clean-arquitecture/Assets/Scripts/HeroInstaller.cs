using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Estructura._3_Framework;
using UnityEngine;
using Input = Assets.Scripts.Estructura._3_Framework.Input;

namespace Assets.Scripts
{
    public class HeroInstaller : MonoBehaviour
    {     
        [SerializeField] private HeroView _heroView;

        private Mover _moveUseCase;
        private Jumper _jumpUseCase;

        private InputModel _inputModel;
        private GroundGateway _groundGateway;

        public void Configure(InputModel inputModel, GroundGateway groundDataAccess)
        {
            _inputModel = inputModel;
            _groundGateway = groundDataAccess;
        }

        public void Initialize()
        {
            InitializeHero();
            HeroController inputController = new HeroController(_inputModel, _moveUseCase, _jumpUseCase);
        }

        public void InitializeHero()
        {
            HeroViewModel _heroViewModel = new HeroViewModel();
            HeroPresenter _heroPresenter = new HeroPresenter(_heroViewModel);

            _moveUseCase = new MoveUseCase(_heroPresenter);
            _jumpUseCase = new JumpUseCase(_heroPresenter, _groundGateway);
            _heroView.Configure(_heroViewModel);
        }
    }
}
