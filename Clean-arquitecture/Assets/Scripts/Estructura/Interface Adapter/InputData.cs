namespace Assets.Scripts
{
    public class InputData
    {
        private string _arma;
        private float _damage;

        public InputData(string arma, float damage)
        {
            _arma = arma;
            _damage = damage;
        }

        public string Arma  => _arma; 
        public float Damage => _damage;
    }
}
