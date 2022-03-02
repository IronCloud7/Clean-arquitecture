using Assets.Scripts.Estructura._1_Aplication;
using System;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroController : IDisposable
    {
        private HeroViewModel _heroViewModel;

        private Mover _moveUseCase;
        private Jumper _jumpUseCase;
        private Attacker _attackUseCase;

        public HeroController(HeroViewModel heroViewModel, Mover moveUseCase, Jumper jumpUseCase, Attacker attackUseCase)
        {
            _heroViewModel = heroViewModel;

            _moveUseCase = moveUseCase;
            _jumpUseCase = jumpUseCase;
            _attackUseCase = attackUseCase;

            _heroViewModel.HAxisPressed.Subscribe(OnHAxisPressed);
            _heroViewModel.VAxisPressed.Subscribe(OnVAxisPressed);
            _heroViewModel.Button1Pressed.Subscribe(OnButton1Pressed);
            _heroViewModel.Button2Pressed.Subscribe(OnButton2Pressed);
            _heroViewModel.Button3Pressed.Subscribe(OnButton3Pressed);
            _heroViewModel.Button4Pressed.Subscribe(OnButton4Pressed);
            _heroViewModel.Button5Pressed.Subscribe(OnButton5Pressed);
            _heroViewModel.Button6Pressed.Subscribe(OnButton6Pressed);
            _heroViewModel.Button7Pressed.Subscribe(OnButton7Pressed);
            _heroViewModel.Button8Pressed.Subscribe(OnButton8Pressed);

        }

        public void OnButton1Pressed()
        {
            _jumpUseCase.Jump(_heroViewModel.IsGrounded);
        }

        public void OnButton2Pressed()
        {

        }

        public void OnButton3Pressed()
        {
            //_jumpUseCase.Jump();
        }

        public void OnButton4Pressed()
        {
         
        }

        public void OnButton5Pressed()
        {
            _attackUseCase.Attack();
        }

        public void OnButton6Pressed()
        {
        
        }

        public void OnButton7Pressed()
        {
           
        }

        public void OnButton8Pressed()
        {
            //_jumpUseCase.Jump();
        }

        private void OnHAxisPressed()
        {
            _moveUseCase.Move(_heroViewModel.HAxisPressed.Value, _heroViewModel.DeltaTime, _heroViewModel.IsRunning);
        }

        private void OnVAxisPressed()
        {
            //_moveUseCase.MoveVAxis(_heroViewModel.VAxisPressed.Value, _heroViewModel.DeltaTime);
        }

        public void Dispose()
        {
            _heroViewModel.HAxisPressed.Unsubscribe(OnHAxisPressed);
            _heroViewModel.VAxisPressed.Unsubscribe(OnVAxisPressed);
            _heroViewModel.Button1Pressed.Unsubscribe(OnButton1Pressed);
            _heroViewModel.Button2Pressed.Unsubscribe(OnButton2Pressed);
            _heroViewModel.Button3Pressed.Unsubscribe(OnButton3Pressed);
            _heroViewModel.Button4Pressed.Unsubscribe(OnButton4Pressed);
            _heroViewModel.Button5Pressed.Unsubscribe(OnButton5Pressed);
            _heroViewModel.Button6Pressed.Unsubscribe(OnButton6Pressed);
            _heroViewModel.Button7Pressed.Unsubscribe(OnButton7Pressed);
            _heroViewModel.Button8Pressed.Unsubscribe(OnButton8Pressed);
        }
    }
}
