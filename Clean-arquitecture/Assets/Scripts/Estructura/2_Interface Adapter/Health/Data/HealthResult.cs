namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HealthResult
    {
        private string _id;
        private int _maxHealth;
        private int _currentHealth;

        public string Id { get => _id; set => _id = value; }
        public int MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
    }
}
