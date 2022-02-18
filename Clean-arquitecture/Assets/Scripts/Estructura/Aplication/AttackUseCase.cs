using Assets.Scripts.Estructura.Interface_Adapter;
using System;

namespace Assets.Scripts
{
    public class AttackUseCase : Attacker
    {
        private UpdaterDamage _updaterDamage;

        //public event Action<InputData> OnDamageUpdated;

        //public delegate void OnDamageUpdateDelegate(InputData inputData);
        //public static event OnDamageUpdateDelegate OnDamageEvent;

        //public static event Action<InputData> OnDamageAction;
        public AttackUseCase(UpdaterDamage updaterDamage)
        {
            _updaterDamage = updaterDamage;
        }


        public void Attack(InputData inputData)
        {
            Console.WriteLine("Ataque!");

            _updaterDamage.UpdateDamage(inputData);
            //OnDamageUpdated?.Invoke(inputData);

     
            //OnDamageEvent?.Invoke(inputData);
            //OnDamageAction?.Invoke(inputData);
        }
    }
}
