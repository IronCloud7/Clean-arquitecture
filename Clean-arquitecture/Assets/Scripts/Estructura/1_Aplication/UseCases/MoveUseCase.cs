using Assets.Scripts.Estructura._2_Interface_Adapter.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Estructura._1_Aplication.UseCases
{
    class MoveUseCase : Mover
    {
        private UpdaterMove _updaterMove;

        public MoveUseCase(UpdaterMove updaterMove)
        {
            _updaterMove = updaterMove;
        }

        public void Move(HeroInputData inputData)
        {
            HeroOutputData heroOutputData = new HeroOutputData(inputData.HorizontalAxis , inputData.VerticalAxis);

            _updaterMove.UpdateMove(heroOutputData);
        }
    }
}
