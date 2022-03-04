using System;

namespace Assets.Scripts.Estructura._1_Aplication
{
    public class HealthRefreshUseCase : HealthRefresher
    {
        UpdaterHealth _updaterHealth;
        HealthDataAccess _healthRepository;

        public HealthRefreshUseCase(UpdaterHealth updaterHealth, HealthDataAccess healthRepository)
        {
            _updaterHealth = updaterHealth;
            _healthRepository = healthRepository;
        }

        public void Refresh(HealthInputData inputData)
        {
            var health = _healthRepository.GetHealth(inputData.HealthId);

            HealthOutputData outputData = new HealthOutputData(health.MaxHealth, health.CurrentHealth);

            _updaterHealth.UpdateHealth(outputData);
        }
    }
}
