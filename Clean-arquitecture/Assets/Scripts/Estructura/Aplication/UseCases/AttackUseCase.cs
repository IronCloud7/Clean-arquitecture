using Assets.Scripts.Estructura.Interface_Adapter;
using System;

namespace Assets.Scripts
{
    public class AttackUseCase : Attacker
    {
        private UpdaterDamage _updaterDamage;
        private WeaponGateway _weaponGateway;

        //public event Action<InputData> OnDamageUpdated;

        //public delegate void OnDamageUpdateDelegate(InputData inputData);
        //public static event OnDamageUpdateDelegate OnDamageEvent;

        //public static event Action<InputData> OnDamageAction;
        public AttackUseCase(UpdaterDamage updaterDamage, WeaponGateway weaponGateway)
        {
            _updaterDamage = updaterDamage;
            _weaponGateway = weaponGateway;
        }


        public void Attack(InputData inputData)
        {
            var weapon = _weaponGateway.GetWeapon(inputData.WeaponId);

            Console.WriteLine("Ataque!");

            OutputData outputData = new OutputData(weapon.Nombre, weapon.Danyo);

            _updaterDamage.UpdateDamage(outputData);
            //OnDamageUpdated?.Invoke(inputData);
        }
    }
}
