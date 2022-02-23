namespace Assets.Scripts.Estructura._1_Aplication
{
    public class JumpUseCase : Jumper
    {
        private UpdaterJump _updaterJump;
        private GroundGateway _groundDataAccess;

        public JumpUseCase(UpdaterJump updaterJump, GroundGateway groundDataService)
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
