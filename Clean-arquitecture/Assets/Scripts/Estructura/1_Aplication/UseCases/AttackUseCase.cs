namespace Assets.Scripts.Estructura._1_Aplication
{
    public class AttackUseCase : Attacker
    {
        private UpdaterDamage _updaterDamage;
        private WeaponDataAccess _weaponRepository;

        public AttackUseCase(UpdaterDamage updaterDamage, WeaponDataAccess weaponRepository)
        {
            _updaterDamage = updaterDamage;
            _weaponRepository = weaponRepository;
        }

        public void Attack(WeaponInputData inputData)
        {
            var weapon = _weaponRepository.GetWeapon(inputData.WeaponId);

            WeaponOutputData outputData = new WeaponOutputData(weapon.Nombre, weapon.Danyo);

            _updaterDamage.UpdateDamage(outputData);
        }
    }
}
