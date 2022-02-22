using Assets.Scripts.Estructura._1_Aplication;
using UnityEngine;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HealthPresenter : UpdaterHealth
    {
        private readonly HealthViewModel _healthViewModel;

        public HealthPresenter(HealthViewModel healthViewModel)
        {
            _healthViewModel = healthViewModel;
        }

        public void UpdateHealth(HealthOutputData healthOutputData)
        {
            _healthViewModel.MaxHealth.Value = healthOutputData.MaxHealth;
            _healthViewModel.CurrentHealth.Value = healthOutputData.CurrentHealth;
        }
    }
}
