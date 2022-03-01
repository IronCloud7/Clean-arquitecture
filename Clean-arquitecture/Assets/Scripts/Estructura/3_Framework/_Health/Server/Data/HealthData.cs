using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    [CreateAssetMenu(menuName = "Custom/Data/Health Data")]
    public class HealthData : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private int _maxHealth;
        [SerializeField] private int _currentHealth;

        public string Id { get => _id; set => _id = value; }
        public int MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
    }
}
