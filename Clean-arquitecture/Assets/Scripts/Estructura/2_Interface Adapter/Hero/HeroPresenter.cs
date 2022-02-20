using Assets.Scripts.Estructura._1_Aplication.Hero.Models;
using Assets.Scripts.Estructura._1_Aplication.Hero.Service;

namespace Assets.Scripts.Estructura._2_Interface_Adapter.Hero
{
    public class HeroPresenter : UpdaterMove, UpdaterJump
    {
        private readonly HeroViewModel _heroViewModel;

        public HeroPresenter(HeroViewModel heroViewModel)
        {
            _heroViewModel = heroViewModel;
        }

        public void UpdateJump()
        {
            _heroViewModel.Jump.Execute();
        }

        public void UpdateMove(HeroOutputData heroOutputData)
        {
            _heroViewModel.HorizontalAxis.Value = heroOutputData.HorizontalAxis;
            _heroViewModel.VerticalAxis.Value = heroOutputData.VerticalAxis;
        }
    }
}
