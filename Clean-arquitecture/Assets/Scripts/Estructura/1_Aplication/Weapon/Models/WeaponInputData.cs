namespace Assets.Scripts.Estructura._1_Aplication.Weapon.Models
{
    public class WeaponInputData
    {
        private string _weaponId;

        public WeaponInputData(string weaponId)
        {
            _weaponId = weaponId;
        }

        public string WeaponId { get => _weaponId; set => _weaponId = value; }
    }
}
