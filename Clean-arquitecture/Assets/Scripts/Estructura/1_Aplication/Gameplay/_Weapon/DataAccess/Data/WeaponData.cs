namespace Assets.Scripts.Estructura._1_Aplication
{
    public class WeaponData
    {
        public WeaponData() => _attributes = new WeaponAttributes();

        private string _id;
        private string _name;
        private WeaponAttributes _attributes;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public WeaponAttributes Attributes { get => _attributes; set => _attributes = value; }

        public class WeaponAttributes
        {
            private int _damage;
            private float _attackRange;
            private int _penetrationRange;
            private float _secondsBetweenAttacks;

            public int Damage { get => _damage; set => _damage = value; }
            public float AttackRange { get => _attackRange; set => _attackRange = value; }
            public int PenetrationRange { get => _penetrationRange; set => _penetrationRange = value; }
            public float SecondsBetweenAttacks { get => _secondsBetweenAttacks; set => _secondsBetweenAttacks = value; }   
        }
    }
}
