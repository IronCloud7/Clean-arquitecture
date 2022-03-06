using Assets.Scripts.Estructura._1_Aplication;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroPresenter : UpdaterMove, UpdaterJump, UpdaterAttack
    {
        private readonly HeroViewModel _heroViewModel;

        public HeroPresenter(HeroViewModel heroViewModel)
        {
            _heroViewModel = heroViewModel;
        }

        public void UpdateAttack()
        {
            _heroViewModel.DoAttack.Value = true;
        }

        public void UpdateJump(float velocity)
        {
            _heroViewModel.JumpVelocity.Value = velocity;
        }

        public void UpdateMove(float position)
        {
            _heroViewModel.Movement.Value = position;
        }
    }
}
