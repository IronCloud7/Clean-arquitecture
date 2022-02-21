namespace Assets.Scripts.Estructura._1_Aplication
{
    public class Hero
    {
        private string _id;
        private string _name;
        private string _weaponId;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string WeaponId { get => _weaponId; set => _weaponId = value; }
    }
}

