using Assets.Scripts.Estructura._1_Aplication;
using System;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class InputController : IDisposable
    {
        private InputModel _inputModel;
        private Attacker _attackUseCase;
        private Mover _moveUseCase;
        private Jumper _jumpUseCase;

        public InputController(InputModel inputModel, Attacker attackUseCase, Mover moveUseCase, Jumper jumpUseCase)
        {
            _inputModel = inputModel;
            _attackUseCase = attackUseCase;
            _moveUseCase = moveUseCase;
            _jumpUseCase = jumpUseCase;

            _inputModel.BotonA.Subscribe(BotonAUpdated);
            _inputModel.BotonB.Subscribe(BotonBUpdated);
            _inputModel.BotonX.Subscribe(BotonXUpdated);
            _inputModel.BotonY.Subscribe(BotonYUpdated);

            _inputModel.HorizontalAxis.Subscribe(AxisUpdated);
            _inputModel.VerticalAxis.Subscribe(AxisUpdated);
        }

        public void BotonAUpdated()
        {
            _attackUseCase.Attack(new WeaponInputData("1"));
        }

        public void BotonBUpdated()
        {
            _attackUseCase.Attack(new WeaponInputData("2"));
        }

        public void BotonXUpdated()
        {
            _jumpUseCase.Jump();
        }

        public void BotonYUpdated()
        {
            _attackUseCase.Attack(new WeaponInputData("3"));
        }

        public void AxisUpdated()
        {
            _moveUseCase.Move(new HeroInputData(_inputModel.HorizontalAxis.Value, _inputModel.VerticalAxis.Value));
        }


        public void Dispose()
        {
            _inputModel.BotonA.Unsubscribe(BotonAUpdated);
            _inputModel.BotonB.Unsubscribe(BotonBUpdated);
            _inputModel.BotonX.Unsubscribe(BotonXUpdated);
            _inputModel.BotonY.Unsubscribe(BotonYUpdated);

            _inputModel.HorizontalAxis.Unsubscribe(AxisUpdated);
            _inputModel.VerticalAxis.Unsubscribe(AxisUpdated);
        }
    }
}
