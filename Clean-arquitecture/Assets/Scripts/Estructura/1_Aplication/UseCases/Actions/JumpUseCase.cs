namespace Assets.Scripts.Estructura._1_Aplication
{
    public class JumpUseCase : Jumper
    {
        private Hero _gameplayHero;
        private UpdaterJump _updaterJump;

        public JumpUseCase(Hero gameplayHero, UpdaterJump updaterJump)
        {
            _gameplayHero = gameplayHero;
            _updaterJump = updaterJump;           
        }

        public void Jump(bool isGround)
        {
            if (isGround && _gameplayHero.CanJump())
            {
                var jumpVelocity = _gameplayHero.Jump();
                _updaterJump.UpdateJump(jumpVelocity);
            }
               
        }
    }
}
