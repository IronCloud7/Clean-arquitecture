namespace Assets.Scripts.Estructura._1_Aplication
{
    public class AttackUseCase : Attacker
    {
        private GameplayHero _gameplayHero;
        private UpdaterAttack _updaterAttack;

        public AttackUseCase(GameplayHero gameplayHero, UpdaterAttack updaterAttack)
        {
            _gameplayHero = gameplayHero;
            _updaterAttack = updaterAttack;      
        }

        public void Attack()
        {
            if (_gameplayHero.CanAttack())
            {
                _gameplayHero.Attack();

                _updaterAttack.UpdateAttack(true);
            }
         
        }
    }
}
