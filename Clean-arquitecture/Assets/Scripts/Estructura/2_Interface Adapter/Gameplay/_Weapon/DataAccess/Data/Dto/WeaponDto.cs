namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponDto
    {
        private string _id;
        private string _name;
        private int _damage;
        private float _attackRange;
        private int _penetrationRange;
        private float _secondsBetweenAttacks;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Damage { get => _damage; set => _damage = value; }
        public float AttackRange { get => _attackRange; set => _attackRange = value; }
        public int PenetrationRange { get => _penetrationRange; set => _penetrationRange = value; }
        public float SecondsBetweenAttacks { get => _secondsBetweenAttacks; set => _secondsBetweenAttacks = value; }

    }
}
