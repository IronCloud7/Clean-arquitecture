namespace Assets.Scripts.Estructura._1_Aplication
{
    public class JumpUseCase : Jumper
    {
        private UpdaterJump _updaterJump;
        private GroundDataAccess _groundDataAccess;

        public JumpUseCase(UpdaterJump updaterJump, GroundDataAccess groundDataService)
        {
            _updaterJump = updaterJump;
            _groundDataAccess = groundDataService;
        }

        public void Jump()
        {
            if (_groundDataAccess.isGround())
            {
                _updaterJump.UpdateJump();
            }
        }
    }
}
