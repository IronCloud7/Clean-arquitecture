using Assets.Scripts.Estructura._1_Aplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HealthRepository : HealthDataAccess
    {
        private readonly HealthGateway _healthGateway;
        private Dictionary<string, Health> _healths;

        public HealthRepository(HealthGateway healthGateway)
        {
            _healthGateway = healthGateway;

            _healths = new Dictionary<string, Health>();
        }

        public Health GetHealth(string id)
        {
            Health health;

            if (_healths.TryGetValue(id, out health))
            {
                return health;
            }

            var healthDto = _healthGateway.GetHealth(id);

            health = new Health();
            health.Id = healthDto.Id;
            health.MaxHealth = healthDto.MaxHealth;
            health.CurrentHealth = healthDto.CurrentHealth;

            _healths.Add(health.Id, health);

            return health;
        }
    }
}
