using Assets.Scripts.Estructura._2_Interface_Adapter.Hero;
using System;


namespace Assets.Scripts.Estructura._1_Aplication.UseCases
{
    public class JumpUseCase : Jumper
    {
        private UpdaterJump _updaterJump;

        public JumpUseCase(UpdaterJump updaterJump)
        {
            _updaterJump = updaterJump;
        }

        public void Jump()
        {
            _updaterJump.UpdateJump();
        } 
    }
}
