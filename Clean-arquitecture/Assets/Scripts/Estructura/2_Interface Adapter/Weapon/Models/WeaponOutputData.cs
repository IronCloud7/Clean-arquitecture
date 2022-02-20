namespace Assets.Scripts.Estructura.Interface_Adapter
{
    public class WeaponOutputData
    {
        private string _arma;
        private float _damage;

        public WeaponOutputData(string arma, float damage)
        {
            _arma = arma;
            _damage = damage;
        }

        public string Nombre  => _arma; 
        public float Danyo => _damage;
    }
}
