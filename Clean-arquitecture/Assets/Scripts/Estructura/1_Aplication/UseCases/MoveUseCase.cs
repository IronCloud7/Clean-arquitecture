namespace Assets.Scripts.Estructura._1_Aplication
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
