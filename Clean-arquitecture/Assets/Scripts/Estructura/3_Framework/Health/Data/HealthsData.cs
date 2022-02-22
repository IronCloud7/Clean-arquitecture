using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    [CreateAssetMenu(menuName = "Custom/Healths Data")]
    public class HealthsData : ScriptableObject
    {
        [SerializeField] private HealthData[] _healths;
        private Dictionary<string, HealthData> _idToHealth;

        public HealthData[] Healths => _healths;

        public void Awake()
        {
            _idToHealth = new Dictionary<string, HealthData>();
            foreach (var health in _healths)
            {
                _idToHealth.Add(health.Id, health);
            }
        }

        public HealthData GetHealthById(string id)
        {
            if (!_idToHealth.TryGetValue(id, out var healthData))
            {
                throw new ArgumentOutOfRangeException($"Weapon with Id {id} does not exist");
            }

            return healthData;
        }
    }
}
