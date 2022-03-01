using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Estructura._1_Aplication
{
    public class HealthOutputData
    {
        private int _maxHealth;
        private int _currentHealth;

        public HealthOutputData(int maxHealth, int currentHealth)
        {
            _maxHealth = maxHealth;
            _currentHealth = currentHealth;
        }

        public int MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
    }
}
