namespace Assets.Scripts.Estructura._1_Aplication
{
    public class AttackUseCase : Attacker
    {
        private Hero _gameplayHero;
        private UpdaterAttack _updaterAttack;
        private UpdaterAttack _updaterCollision;

        public AttackUseCase(Hero gameplayHero, UpdaterAttack updaterAttack, UpdaterAttack updaterCollision)
        {
            _gameplayHero = gameplayHero;
            _updaterAttack = updaterAttack;
            _updaterCollision = updaterCollision;
        }

        public void Attack()
        {
            if (_gameplayHero.CanAttack())
            {
                _gameplayHero.Attack();

                _updaterAttack.UpdateAttack();
                _updaterCollision.UpdateAttack();
            }
         
        }
    }
}
