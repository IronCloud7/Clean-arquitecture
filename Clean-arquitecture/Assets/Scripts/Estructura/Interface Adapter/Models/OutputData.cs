namespace Assets.Scripts
{
    public class OutputData
    {
        private string _arma;
        private float _damage;

        public OutputData(string arma, float damage)
        {
            _arma = arma;
            _damage = damage;
        }

        public string Nombre  => _arma; 
        public float Danyo => _damage;
    }
}
