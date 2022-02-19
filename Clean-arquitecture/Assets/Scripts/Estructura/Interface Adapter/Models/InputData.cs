namespace Assets.Scripts
{
    public class InputData
    {
        private string _weaponId;

        public InputData(string weaponId)
        {
            _weaponId = weaponId;
        }

        public string WeaponId { get => _weaponId; set => _weaponId = value; }
    }
}
