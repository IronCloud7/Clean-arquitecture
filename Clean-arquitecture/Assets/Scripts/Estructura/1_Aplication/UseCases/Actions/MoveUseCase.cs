namespace Assets.Scripts.Estructura._1_Aplication
{
    public class MoveUseCase : Mover
    {
        private GameplayHero _gameplayHero;
        private UpdaterMove _updaterMove;
       
        public MoveUseCase(GameplayHero gameplayHero, UpdaterMove updaterMove)
        {
            _gameplayHero = gameplayHero;
            _updaterMove = updaterMove;    
        }

        public void Move(float direction, float deltaTime, bool run)
        {
            if (_gameplayHero.CanMove())
            {
                var move = _gameplayHero.Move(direction, deltaTime, run);     
                _updaterMove.UpdateMove(move);
            }          
        }
    }
}
