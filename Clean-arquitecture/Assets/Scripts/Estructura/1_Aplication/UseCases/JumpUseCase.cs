﻿namespace Assets.Scripts.Estructura._1_Aplication
{
    public class JumpUseCase : Jumper
    {
        private UpdaterJump _updaterJump;
        private HeroColisionerGateway _heroCollisioner;

        public JumpUseCase(UpdaterJump updaterJump, HeroColisionerGateway heroCollisioner)
        {
            _updaterJump = updaterJump;
            _heroCollisioner = heroCollisioner;
        }

        public void Jump()
        {
            if (_heroCollisioner.isGround())
            {
                _updaterJump.UpdateJump();
            }
        }
    }
}
