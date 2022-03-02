namespace Assets.Scripts.Estructura._1_Aplication
{
    public class MoveUseCase : Mover
    {
        private Hero _gameplayHero;
        private UpdaterMove _updaterMove;
       
        public MoveUseCase(Hero gameplayHero, UpdaterMove updaterMove)
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
