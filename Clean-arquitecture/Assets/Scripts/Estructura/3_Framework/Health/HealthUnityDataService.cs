using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class HealthUnityDataService : MonoBehaviour, HealthDataService
    {
        [SerializeField] private HealthsData _healthsData;

        public void Awake()
        {
            _healthsData = Instantiate(_healthsData);
        }

        public HealthResult GetHealth(string id)
        {
            var healthData = _healthsData.GetHealthById(id);

            var healthResult = new HealthResult();
            healthResult.Id = healthData.Id;
            healthResult.MaxHealth = healthData.MaxHealth;
            healthResult.CurrentHealth = healthData.CurrentHealth;


            return healthResult;
        }
    }
}
