using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Estructura._1_Aplication
{
    public interface HealthDataAccess
    {
        public Health GetHealth(string id);
    }
}
