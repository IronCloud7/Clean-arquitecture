using Assets.Scripts.Estructura._1_Aplication.Hero.Models;
using Assets.Scripts.Estructura._1_Aplication.Hero.Service;

namespace Assets.Scripts.Estructura._1_Aplication.UseCases
{
    public class MoveUseCase : Mover
    {
        private UpdaterMove _updaterMove;

        public MoveUseCase(UpdaterMove updaterMove)
        {
            _updaterMove = updaterMove;
        }

        public void Move(HeroInputData inputData)
        {
            HeroOutputData heroOutputData = new HeroOutputData(inputData.HorizontalAxis, inputData.VerticalAxis);

            _updaterMove.UpdateMove(heroOutputData);
        }
    }
}
