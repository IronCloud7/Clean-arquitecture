using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Estructura._1_Aplication
{
    public class HealthInputData
    {
        private string _healthId;

        public HealthInputData(string healthId)
        {
            _healthId = healthId;
        }
        public string HealthId { get => _healthId; set => _healthId = value; }
    }
}
