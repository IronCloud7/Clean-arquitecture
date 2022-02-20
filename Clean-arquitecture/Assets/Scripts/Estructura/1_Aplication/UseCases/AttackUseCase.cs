using Assets.Scripts.Estructura._1_Aplication.Weapon.Gateway;
using Assets.Scripts.Estructura._1_Aplication.Weapon.Models;
using Assets.Scripts.Estructura._1_Aplication.Weapon.Service;

namespace Assets.Scripts.Estructura._1_Aplication.UseCases
{
    public class AttackUseCase : Attacker
    {
        private UpdaterDamage _updaterDamage;
        private WeaponGateway _weaponGateway;

        public AttackUseCase(UpdaterDamage updaterDamage, WeaponGateway weaponGateway)
        {
            _updaterDamage = updaterDamage;
            _weaponGateway = weaponGateway;
        }

        public void Attack(WeaponInputData inputData)
        {
            var weapon = _weaponGateway.GetWeapon(inputData.WeaponId);

            WeaponOutputData outputData = new WeaponOutputData(weapon.Nombre, weapon.Danyo);

            _updaterDamage.UpdateDamage(outputData);
        }
    }
}
