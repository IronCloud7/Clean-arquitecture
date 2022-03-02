using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HealthGatewayImp : HealthGateway
    {
        private HealthDataService _healthDataService;

        public HealthGatewayImp(HealthDataService healthDataService)
        {
            _healthDataService = healthDataService;
        }

        public HealthDto GetHealth(string id)
        {
            var healthResult = _healthDataService.GetHealth(id);

            var healthDto = new HealthDto();
            healthDto.Id = healthResult.Id;
            healthDto.MaxHealth = healthResult.MaxHealth;
            healthDto.CurrentHealth = healthResult.CurrentHealth;

            return healthDto;
        }
    }
}
