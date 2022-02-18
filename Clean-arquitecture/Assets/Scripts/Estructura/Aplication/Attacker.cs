using System;

namespace Assets.Scripts
{
    public interface Attacker
    {
        public void Attack(InputData inputData);
        //public event Action<InputData> OnDamageUpdated;
    }
}
