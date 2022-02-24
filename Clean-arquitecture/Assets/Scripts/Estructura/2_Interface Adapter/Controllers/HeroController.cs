using Assets.Scripts.Estructura._1_Aplication;
using System;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroController : IDisposable
    {
        private InputModel _inputModel;
        private Mover _moveUseCase;
        private Jumper _jumpUseCase;

        public HeroController(InputModel inputModel, Mover moveUseCase, Jumper jumpUseCase)
        {
            _inputModel = inputModel;
            _moveUseCase = moveUseCase;
            _jumpUseCase = jumpUseCase;

            _inputModel.BotonX.Subscribe(BotonXUpdated);
            _inputModel.HorizontalAxis.Subscribe(AxisUpdated);
            _inputModel.VerticalAxis.Subscribe(AxisUpdated);
        }

        public void BotonXUpdated()
        {
            _jumpUseCase.Jump();
        }

        public void AxisUpdated()
        {
            _moveUseCase.Move(new HeroInputData(_inputModel.HorizontalAxis.Value, _inputModel.VerticalAxis.Value));
        }


        public void Dispose()
        {
            _inputModel.BotonX.Unsubscribe(BotonXUpdated);
            _inputModel.HorizontalAxis.Unsubscribe(AxisUpdated);
            _inputModel.VerticalAxis.Unsubscribe(AxisUpdated);
        }
    }
}
